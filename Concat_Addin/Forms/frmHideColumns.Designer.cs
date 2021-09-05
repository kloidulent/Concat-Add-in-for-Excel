namespace Concat_Addin.Forms
{
    partial class frmHideColumns
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedAddress = new System.Windows.Forms.TextBox();
            this.btnSelectRange = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.chkTreatZerosAsBlank = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTreatZerosAsBlank);
            this.groupBox1.Controls.Add(this.btnSelectRange);
            this.groupBox1.Controls.Add(this.txtSelectedAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Range";
            // 
            // txtSelectedAddress
            // 
            this.txtSelectedAddress.Location = new System.Drawing.Point(143, 38);
            this.txtSelectedAddress.Name = "txtSelectedAddress";
            this.txtSelectedAddress.Size = new System.Drawing.Size(139, 20);
            this.txtSelectedAddress.TabIndex = 1;
            // 
            // btnSelectRange
            // 
            this.btnSelectRange.Location = new System.Drawing.Point(288, 36);
            this.btnSelectRange.Name = "btnSelectRange";
            this.btnSelectRange.Size = new System.Drawing.Size(27, 23);
            this.btnSelectRange.TabIndex = 2;
            this.btnSelectRange.Text = "...";
            this.btnSelectRange.UseVisualStyleBackColor = true;
            this.btnSelectRange.Click += new System.EventHandler(this.btnSelectRange_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(291, 211);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 1;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(381, 211);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // chkTreatZerosAsBlank
            // 
            this.chkTreatZerosAsBlank.AutoSize = true;
            this.chkTreatZerosAsBlank.Location = new System.Drawing.Point(143, 73);
            this.chkTreatZerosAsBlank.Name = "chkTreatZerosAsBlank";
            this.chkTreatZerosAsBlank.Size = new System.Drawing.Size(126, 17);
            this.chkTreatZerosAsBlank.TabIndex = 4;
            this.chkTreatZerosAsBlank.Text = "Treat Zero as Blank?";
            this.chkTreatZerosAsBlank.UseVisualStyleBackColor = true;
            // 
            // frmHideColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 256);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHideColumns";
            this.Text = "frmHideColumns";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedAddress;
        private System.Windows.Forms.Button btnSelectRange;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox chkTreatZerosAsBlank;
    }
}