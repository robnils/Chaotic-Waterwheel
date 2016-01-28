using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using Wolfram.NETLink;

namespace waterwheel1
{

    public partial class WaterWheel : Form
    {

        //transformation for the graphics
        private float s1, s2, t1, t2;
        Matrix m, minv;
        //the radious and centre of the wheel
        private float r, cX, cY;
        //binding for graph visuluation
        private BindingSource bsgraph;
        private Movement move;
        private List<Movement> datastore;
        //parameters of the model
        private Params prm;
        //list of buckets in the system
        Bucket b;
        private List<Bucket> buckets;
        //variables for the animation
        private Timer timer;
        private int iter, finaltime;
        private float time;
        private float[,] data;
        private float rayleigh = 28;//constant for the double pendelum
        private string path = Directory.GetCurrentDirectory();//package address
        private int limitbucket = 15;

        public WaterWheel()
        {
            InitializeComponent();
        }

        private void SetupTransform()
        {
            //world points
            float x1 = 0, y1 = 0, x2 = 100, y2 = 100;
            //device points
            Rectangle crect = this.ClientRectangle;
            float x1d = (float)5 * crect.Width / 14;//up left corner
            float y1d = 0.1f * crect.Height;//up left corner
            float x2d = (float)13 * crect.Width / 14;//bottom rigth corner
            float y2d = 0.9f * crect.Height;//bottom right corner
            //calcutae the scalling
            s1 = (x1d - x2d) / (x1 - x2);
            s2 = (y1d - y2d) / (y1 - y2);
            t1 = (x1 * x2d - x2 * x1d) / (x1 - x2);
            t2 = (y1 * y2d - y2 * y1d) / (y1 - y2);
            m = new Matrix();
            m.Translate(t1, t2);//transalation
            m.Scale(s1, s2);//scaling
            //get the inverse
            m.Invert();
            minv = m.Clone();
            m.Invert();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prm = new Params();
            move = new Movement();
            bsgraph = new BindingSource();
            datastore = new List<Movement>();
            //setup the parameters - call the extra windows form
            frmParameters p = new frmParameters();
            //user can use preset values
            p.Param_data.Buckets = 5;
            p.Param_data.Inflow = 10;
            p.Param_data.Outflow = 1;
            p.Finaltime = 10;
            p.Movement.Omega = 0.1f;
            DialogResult d = p.ShowDialog();
            //or set is own one
            if (d == DialogResult.OK)
            {
                prm.Buckets = p.Param_data.Buckets;
                prm.Inflow = p.Param_data.Inflow;
                prm.Outflow = p.Param_data.Outflow;
                finaltime = p.Finaltime;
                move.Omega = p.Movement.Omega;
            }
            else if (d == DialogResult.Cancel)
            {
                prm.Buckets = 5;
                prm.Theta = 0;
                prm.Inflow = 10;
                prm.Outflow = 1;
                finaltime = 10;
                move.Omega = 0.1f;
            }
            //setup the transform for painting
            SetupTransform();
            //initialize the picture
            r = 40;
            cX = 50;
            cY = 50;
            //initialize the list of buckets
            buckets = new List<Bucket>();
            for (int i = 0; i < prm.Buckets; i++)
            {
                b = new Bucket(0);
                buckets.Add(b);
            }
            //initialize the timer
            timer = new Timer();
            timer.Tick += frm_Tick;
            timer.Interval = 50;

            //the text boxes...
            txtUpDownBuckets.DataBindings.Add("Text", prm, "Buckets");
            txtMass.DataBindings.Add("Text", prm, "Mass");
            txtTheta.DataBindings.Add("Text", prm, "Theta");
            txtUpDownBuckets.Maximum = limitbucket;
            txtUpDownBuckets.Minimum = 0;
            textBox1.Visible = false;
            rbNormal.Checked = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float angle;
            Graphics g = e.Graphics;
            g.Transform = m;
            using (Pen p = new Pen(Color.Black, 1 / s1))
            {
                //draw the basic picture
                g.FillEllipse(Brushes.Black, cX - 2, cY - 2, 4, 4);
                //g.DrawEllipse(p, cX - r, cY - r, 2 * r, 2 * r);
                ///draw the buckets
                for (int i = 0; i < prm.Buckets; i++)
                {
                    b = buckets[i];
                    //calculate the angle and the centre for the bucket
                    angle = (float)(prm.Theta + i * 2 * Math.PI / prm.Buckets);
                    b.X = -(float)Math.Sin(angle) * r + cX;
                    b.Y = -(float)Math.Cos(angle) * r + cY;
                    //draw it
                    b.drawbucket(g, s1);                
                }
            }
        }

        private void frm_Tick(object sender, EventArgs e)
        {
            if (iter >= data.GetLength(0))
            {
                timer.Stop();
                btStop_Click(sender,e);
                return;
            }
            prm.Theta = data[iter,0];
            //graph
            Movement p=new Movement();
            p.B=data[iter,2];
            p.Omega = data[iter,3];
            datastore.Add(p);
            //buckets
            prm.Mass = 0;
            for (int i = 0; i < prm.Buckets; i++)
            {
                buckets[i].W = data[iter, i + 4];
                if (buckets[i].W > buckets[i].B) buckets[i].W = buckets[i].B;
                prm.Mass += buckets[i].W;
            }
            //update the text boxes...databindings fails
            time += (float) 0.05;
            txtTime.Text = Convert.ToString(time);
            txtTheta.Text = Convert.ToString(prm.Theta);
            txtMass.Text = Convert.ToString(prm.Mass);
            iter++;///move to next step
            this.Refresh();//redraw the picture
        }

        private string callargument()
        {
            string s="";
            /*(number of buckets, inflow, outflow, constatnt,  raious of wheel, time of animation, initial angle, initial velocity)*/
            s += string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", prm.Buckets,prm.Inflow,prm.Outflow,rayleigh,r/10,finaltime,0,move.Omega);
            return s;
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            
            IKernelLink ml = null;
            textBox1.Visible = true;
            this.Refresh();    
            try
            {
                //clear the graph
                datastore.Clear();
                //call the package
                ml = MathLinkFactory.CreateKernelLink();
                ml.WaitAndDiscardAnswer();
                ml.Evaluate("<<" + string.Format("{0}", path) + @"\Waterwheel_4.m"); //Package contained in waterwheel1\bin\Debug
                ml.WaitAndDiscardAnswer();
                //clever way to call the package
                ml.Evaluate(string.Format("Waterwheel[{0}]", callargument()));
                ml.WaitForAnswer();
                //save the data
                data =(float[,]) ml.GetArray(typeof(float), 2);
                //run the animation
                iter = 0;
                time = 0;
                timer.Start();
                txtUpDownBuckets.Enabled = false;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ml != null) ml.Close();
            }
            textBox1.Visible = false;
            btStart.Enabled = false;
           
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            txtUpDownBuckets.Enabled = true;
            btStart.Enabled = true;
        }


        private void txtUpDownBuckets_ValueChanged(object sender, EventArgs e)
        {
            int oldnum = buckets.Count;
            //txtUpDownBuckets.Update(); this does not work so i will do it like this
            prm.Buckets = (int)txtUpDownBuckets.Value;
            if (prm.Buckets < oldnum)
                //remove some buckets
                buckets.RemoveRange(prm.Buckets, oldnum - prm.Buckets);
            else
                //add some buckets
                for (int i = 0; i < prm.Buckets - oldnum; i++)
                {
                    b = new Bucket(0);
                    buckets.Add(b);
                }
            //refresh the picture
            this.Refresh();
        }

        private void enterParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btStop_Click(sender, e);//stop the animation
            frmParameters p = new frmParameters();
            //save the initial values
            p.Param_data.Buckets = prm.Buckets;
            p.Param_data.Inflow = prm.Inflow;
            p.Param_data.Outflow = prm.Outflow;
            p.Finaltime = finaltime;
            p.Movement.Omega=move.Omega;
            DialogResult d = p.ShowDialog();
            int newnum;
            if (d == DialogResult.OK)
            {
                newnum = p.Param_data.Buckets;
                if (prm.Buckets > newnum)
                    //remove some buckets
                    buckets.RemoveRange(newnum, prm.Buckets - newnum);
                else
                    //add some buckets
                    for (int i = 0; i < newnum - prm.Buckets; i++)
                    {
                        b = new Bucket(0);
                        buckets.Add(b);
                    }
                //save the new values
                prm.Buckets = p.Param_data.Buckets;
                prm.Inflow = p.Param_data.Inflow;
                prm.Outflow = p.Param_data.Outflow;
                finaltime = p.Finaltime;
                move.Omega = p.Movement.Omega;
                //change the value in counter
                txtUpDownBuckets.Value = prm.Buckets;
                //refresh the picture
                this.Refresh();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btShowGraph_Click(object sender, EventArgs e)
        {
            Graph G = new Graph(timer);
            //bind the datasource to the graph
            bsgraph.DataSource = datastore;
            G.UseExistingDataList(bsgraph);
            G.Show();
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            //real wolrd speed
            timer.Interval = 50;
        }

        private void rbSlow_CheckedChanged(object sender, EventArgs e)
        {
            //4* times slower
            timer.Interval = 200;
        }

       

    }
}


class Bucket
{
    //fixed size for the system 
    private int a = 10;
    public int A
    {
        get { return a; }
        set { a = value; }
    }
    private int b = 10;
    public int B
    {
        get { return b; }
        set { b = value; }
    }
    //height of water in the bucket
    private float w;
    public float W
    {
        get { return w; }
        set { w = value; }
    }
    //position of bucket, center of prm.Thetae bucket..prm.Thetaat is on prm.Thetae circle
    private float x;
    public float X
    {
        get { return x; }
        set { x = value; }
    }
    private float y;
    public float Y
    {
        get { return y; }
        set { y = value; }
    }

    public Bucket(float w)
    {
        this.w = w;
    }
    //default constructor
    public Bucket()
    {
    }

    public void drawbucket(Graphics g, float scale)
    {
        using (Pen p = new Pen(Color.Black, 1 / scale))
        {
            g.FillRectangle(Brushes.Blue, x - a / 2, y + b / 2 - w, a, w);
            g.DrawRectangle(p, x - a / 2, y - b / 2, a, b);
            g.DrawRectangle(p, x - a / 2, y + b / 2 - w, a, w);
        }

    }


}
