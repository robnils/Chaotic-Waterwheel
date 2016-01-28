namespace waterwheel1
{
    partial class WaterWheel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUpDownBuckets = new System.Windows.Forms.NumericUpDown();
            this.lblBuckets = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.btShowGraph = new System.Windows.Forms.Button();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbSlow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpDownBuckets)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUpDownBuckets
            // 
            this.txtUpDownBuckets.Location = new System.Drawing.Point(98, 33);
            this.txtUpDownBuckets.Name = "txtUpDownBuckets";
            this.txtUpDownBuckets.Size = new System.Drawing.Size(60, 20);
            this.txtUpDownBuckets.TabIndex = 4;
            this.txtUpDownBuckets.ValueChanged += new System.EventHandler(this.txtUpDownBuckets_ValueChanged);
            // 
            // lblBuckets
            // 
            this.lblBuckets.AutoSize = true;
            this.lblBuckets.Location = new System.Drawing.Point(12, 40);
            this.lblBuckets.Name = "lblBuckets";
            this.lblBuckets.Size = new System.Drawing.Size(46, 13);
            this.lblBuckets.TabIndex = 1;
            this.lblBuckets.Text = "Buckets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterParametersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // enterParametersToolStripMenuItem
            // 
            this.enterParametersToolStripMenuItem.Name = "enterParametersToolStripMenuItem";
            this.enterParametersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.enterParametersToolStripMenuItem.Text = "Enter Parameters";
            this.enterParametersToolStripMenuItem.Click += new System.EventHandler(this.enterParametersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(16, 204);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(40, 21);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "&Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(62, 204);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(40, 21);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mass";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(96, 112);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(60, 20);
            this.txtTime.TabIndex = 6;
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(96, 152);
            this.txtMass.Name = "txtMass";
            this.txtMass.ReadOnly = true;
            this.txtMass.Size = new System.Drawing.Size(60, 20);
            this.txtMass.TabIndex = 7;
            // 
            // btShowGraph
            // 
            this.btShowGraph.Location = new System.Drawing.Point(15, 240);
            this.btShowGraph.Name = "btShowGraph";
            this.btShowGraph.Size = new System.Drawing.Size(86, 21);
            this.btShowGraph.TabIndex = 2;
            this.btShowGraph.Text = "Show Graph";
            this.btShowGraph.UseVisualStyleBackColor = true;
            this.btShowGraph.Click += new System.EventHandler(this.btShowGraph_Click);
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(96, 72);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.ReadOnly = true;
            this.txtTheta.Size = new System.Drawing.Size(60, 20);
            this.txtTheta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Theta";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "LOADING...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(11, 18);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbSlow
            // 
            this.rbSlow.AutoSize = true;
            this.rbSlow.Location = new System.Drawing.Point(11, 41);
            this.rbSlow.Name = "rbSlow";
            this.rbSlow.Size = new System.Drawing.Size(48, 17);
            this.rbSlow.TabIndex = 1;
            this.rbSlow.TabStop = true;
            this.rbSlow.Text = "Slow";
            this.rbSlow.UseVisualStyleBackColor = true;
            this.rbSlow.CheckedChanged += new System.EventHandler(this.rbSlow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSlow);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(14, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // WaterWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.btShowGraph);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lblBuckets);
            this.Controls.Add(this.txtUpDownBuckets);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WaterWheel";
            this.ShowIcon = false;
            this.Text = "Water Wheel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.txtUpDownBuckets)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtUpDownBuckets;
        private System.Windows.Forms.Label lblBuckets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterParametersToolStripMenuItem;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btShowGraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSlow;
        private System.Windows.Forms.RadioButton rbNormal;
    }
}

