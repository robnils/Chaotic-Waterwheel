using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace waterwheel1
{
    public partial class frmParameters : Form
    {
        private Params param_data;
        public Params Param_data
        {
            get { return param_data; }
        }
        private int finaltime;
        public int Finaltime
        {
            get { return finaltime; }
            set { finaltime = value; }
        }
        private Movement movement;

        public Movement Movement
        {
            get { return movement; }
            set { movement = value; }
        }


        public frmParameters()
        {
            InitializeComponent();
            param_data = new Params();
            movement = new Movement();
        }

        private void frmParameters_Load(object sender, EventArgs e)
        {
            txtBuckets.DataBindings.Add("Text", param_data, "Buckets");
            txtInflow.DataBindings.Add("Text", param_data, "Inflow");
            txtOutflow.DataBindings.Add("Text", param_data, "Outflow");
            txtvel.DataBindings.Add("Text", movement, "Omega");
            txtTime.Text = Convert.ToString(finaltime);

        }

        private void txtBuckets_TextChanged(object sender, EventArgs e)
        {
            int d;
            int limitbuckets = 15; //set to what ever bucket limit you want if changed remember to change in Params class
            
            bool bTest = int.TryParse(txtBuckets.Text, out d);
            if (bTest == true && (d<=limitbuckets && d>=0) )
            {
                this.errorProvider1.SetError(txtBuckets, "");
                updateflow();
            }
            else
                this.errorProvider1.SetError(txtBuckets, "This field must contain a number between 0 and "+ string.Format("{0}", limitbuckets));
        }


        private void txtInflow_TextChanged(object sender, EventArgs e)
        {
            float d;
            float limitInflow = 1000; //if changed remember to change in Params class

            bool bTest = float.TryParse(txtInflow.Text, out d);
            if (bTest == true && (d <= limitInflow && d > 0))
            {
                this.errorProvider1.SetError(txtInflow, "");
                updateflow();
            }
            else
                this.errorProvider1.SetError(txtInflow, "This field must contain a positive number between 0 and " + string.Format("{0}", limitInflow));
            updateflow();


        }

        private void txtOutflow_TextChanged(object sender, EventArgs e)
        {
            float d;
            float limitOutflow = 1000; //if changed remember to change in Params class

            bool bTest = float.TryParse(txtOutflow.Text, out d);
            if (bTest == true && (d <= limitOutflow && d > 0))
            {
                this.errorProvider1.SetError(txtOutflow, "");
                updateflow();
            }
            else
                this.errorProvider1.SetError(txtOutflow, "This field must contain a positive number between 0 and " + string.Format("{0}", limitOutflow));

        }
        //function to make sure the inflow and outflow are in reasonable relationship
        private void updateflow()
        {
            float outf, inf;
            int buc;
            float.TryParse(txtInflow.Text, out inf);
            float.TryParse(txtOutflow.Text, out outf);
            int.TryParse(txtBuckets.Text, out buc);
            if (inf > 5 * buc* outf)
             this.errorProvider1.SetError(txtInflow, "Inflow is to high, this setting might cause overfilling of buckets");
            else if(inf< buc* outf)
                this.errorProvider1.SetError(txtInflow, "Inflow is to low, this setting might cause problem in animations");
            else
                this.errorProvider1.SetError(txtInflow, "");
        }


        private void txtvel_TextChanged(object sender, EventArgs e)
        {
            float d;
            float limitvel = 10; //if changed remember to change in Params class

            bool bTest = float.TryParse(txtvel.Text, out d);
            if (bTest == true && (d <= limitvel && d >= -limitvel))
            {
                this.errorProvider1.SetError(txtvel, "");
            }
            else
                this.errorProvider1.SetError(txtvel, "This field should contain a number between"+ string.Format("{0}", -limitvel)+ "and " + string.Format("{0}", limitvel));
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            int d;
            float limitt=200;
            bool bTest = int.TryParse(txtTime.Text, out d);
            if (bTest == true && (d <= limitt && d >= 0))
            {
                this.errorProvider1.SetError(txtTime, "");
                finaltime = Convert.ToInt32(txtTime.Text);
            }
            else
                this.errorProvider1.SetError(txtTime,"This field must contain a number between 0 and " + string.Format("{0}", limitt));
        }

     
    }
}
