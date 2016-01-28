namespace waterwheel1
{
    partial class frmParameters
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
            this.txtBuckets = new System.Windows.Forms.TextBox();
            this.lblBuckets = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtInflow = new System.Windows.Forms.TextBox();
            this.txtOutflow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuckets
            // 
            this.txtBuckets.Location = new System.Drawing.Point(47, 25);
            this.txtBuckets.Name = "txtBuckets";
            this.txtBuckets.Size = new System.Drawing.Size(76, 20);
            this.txtBuckets.TabIndex = 0;
            this.txtBuckets.TextChanged += new System.EventHandler(this.txtBuckets_TextChanged);
            // 
            // lblBuckets
            // 
            this.lblBuckets.AutoSize = true;
            this.lblBuckets.Location = new System.Drawing.Point(44, 9);
            this.lblBuckets.Name = "lblBuckets";
            this.lblBuckets.Size = new System.Drawing.Size(46, 13);
            this.lblBuckets.TabIndex = 1;
            this.lblBuckets.Text = "Buckets";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(160, 136);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 20);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(48, 136);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(76, 20);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtInflow
            // 
            this.txtInflow.Location = new System.Drawing.Point(160, 25);
            this.txtInflow.Name = "txtInflow";
            this.txtInflow.Size = new System.Drawing.Size(76, 20);
            this.txtInflow.TabIndex = 2;
            this.txtInflow.TextChanged += new System.EventHandler(this.txtInflow_TextChanged);
            // 
            // txtOutflow
            // 
            this.txtOutflow.Location = new System.Drawing.Point(160, 78);
            this.txtOutflow.Name = "txtOutflow";
            this.txtOutflow.Size = new System.Drawing.Size(76, 20);
            this.txtOutflow.TabIndex = 3;
            this.txtOutflow.TextChanged += new System.EventHandler(this.txtOutflow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inflow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Outflow";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(264, 24);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(76, 20);
            this.txtTime.TabIndex = 4;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time";
            // 
            // txtvel
            // 
            this.txtvel.Location = new System.Drawing.Point(48, 80);
            this.txtvel.Name = "txtvel";
            this.txtvel.Size = new System.Drawing.Size(76, 20);
            this.txtvel.TabIndex = 1;
            this.txtvel.TextChanged += new System.EventHandler(this.txtvel_TextChanged);
            // 
            // frmParameters
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(396, 199);
            this.Controls.Add(this.txtvel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutflow);
            this.Controls.Add(this.txtInflow);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.lblBuckets);
            this.Controls.Add(this.txtBuckets);
            this.Name = "frmParameters";
            this.Text = "Parameters";
            this.Load += new System.EventHandler(this.frmParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuckets;
        private System.Windows.Forms.Label lblBuckets;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutflow;
        private System.Windows.Forms.TextBox txtInflow;
        private System.Windows.Forms.TextBox txtvel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
    }
}