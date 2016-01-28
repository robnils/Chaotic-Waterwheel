using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace waterwheel1
{
    public partial class Graph : Form
    {
        Timer t;
        public Graph(Timer t)
        {
            InitializeComponent();
            this.t = t;
        }
        public void UseExistingDataList(BindingSource bsref)
        {
            chrtData.DataSource = bsref;//datasource has to be the binding source
            chrtData.Series[0].XValueMember = "B";//asssociate the series of data
            chrtData.Series[0].YValueMembers = "Omega";
        }

        public void graph_tick(object sender, EventArgs e)
        {
            //redraw the graph when tick in animation happen
            chrtData.DataBind();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            t.Tick += graph_tick;
        }

        private void Graph_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Tick -= graph_tick;
        }

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd=new SaveFileDialog();
            DialogResult d=new DialogResult();
            sfd.Filter = "Image files (*.png)|*.png";
            d=sfd.ShowDialog();
            if(d==DialogResult.OK)
            {
                this.chrtData.SaveImage(sfd.FileName,ChartImageFormat.Png);
            }
        }

        private void chrtData_Click(object sender, EventArgs e)
        {

        }
       
    }
}
