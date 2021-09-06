namespace Concat_Addin
{
    partial class frmConcat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCRAfterEachItem = new System.Windows.Forms.CheckBox();
            this.richTextResults = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioTextTransformToLower = new System.Windows.Forms.RadioButton();
            this.radioTextTransformToUpper = new System.Windows.Forms.RadioButton();
            this.radioTextTransformNone = new System.Windows.Forms.RadioButton();
            this.btnSelectRange = new System.Windows.Forms.Button();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAddCharacter = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkDistinctValues = new System.Windows.Forms.CheckBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMessage);
            this.groupBox1.Controls.Add(this.chkDistinctValues);
            this.groupBox1.Controls.Add(this.chkCRAfterEachItem);
            this.groupBox1.Controls.Add(this.richTextResults);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioTextTransformToLower);
            this.groupBox1.Controls.Add(this.radioTextTransformToUpper);
            this.groupBox1.Controls.Add(this.radioTextTransformNone);
            this.groupBox1.Controls.Add(this.btnSelectRange);
            this.groupBox1.Controls.Add(this.txtDelimiter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkAddCharacter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCharacter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSelectedAddress);
            this.groupBox1.Location = new System.Drawing.Point(31, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkCRAfterEachItem
            // 
            this.chkCRAfterEachItem.AutoSize = true;
            this.chkCRAfterEachItem.Location = new System.Drawing.Point(39, 98);
            this.chkCRAfterEachItem.Name = "chkCRAfterEachItem";
            this.chkCRAfterEachItem.Size = new System.Drawing.Size(120, 17);
            this.chkCRAfterEachItem.TabIndex = 15;
            this.chkCRAfterEachItem.Text = "CR after each item?";
            this.chkCRAfterEachItem.UseVisualStyleBackColor = true;
            this.chkCRAfterEachItem.CheckedChanged += new System.EventHandler(this.chkCRAfterEachItem_CheckedChanged);
            // 
            // richTextResults
            // 
            this.richTextResults.Location = new System.Drawing.Point(39, 194);
            this.richTextResults.Name = "richTextResults";
            this.richTextResults.Size = new System.Drawing.Size(342, 197);
            this.richTextResults.TabIndex = 14;
            this.richTextResults.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Text Transformation";
            // 
            // radioTextTransformToLower
            // 
            this.radioTextTransformToLower.AutoSize = true;
            this.radioTextTransformToLower.Location = new System.Drawing.Point(300, 134);
            this.radioTextTransformToLower.Name = "radioTextTransformToLower";
            this.radioTextTransformToLower.Size = new System.Drawing.Size(81, 17);
            this.radioTextTransformToLower.TabIndex = 12;
            this.radioTextTransformToLower.Text = "Lower Case";
            this.radioTextTransformToLower.UseVisualStyleBackColor = true;
            this.radioTextTransformToLower.CheckedChanged += new System.EventHandler(this.radioTextTransformToLower_CheckedChanged);
            // 
            // radioTextTransformToUpper
            // 
            this.radioTextTransformToUpper.AutoSize = true;
            this.radioTextTransformToUpper.Location = new System.Drawing.Point(211, 134);
            this.radioTextTransformToUpper.Name = "radioTextTransformToUpper";
            this.radioTextTransformToUpper.Size = new System.Drawing.Size(81, 17);
            this.radioTextTransformToUpper.TabIndex = 11;
            this.radioTextTransformToUpper.Text = "Upper Case";
            this.radioTextTransformToUpper.UseVisualStyleBackColor = true;
            this.radioTextTransformToUpper.CheckedChanged += new System.EventHandler(this.radioTextTransformToUpper_CheckedChanged);
            // 
            // radioTextTransformNone
            // 
            this.radioTextTransformNone.AutoSize = true;
            this.radioTextTransformNone.Checked = true;
            this.radioTextTransformNone.Location = new System.Drawing.Point(152, 134);
            this.radioTextTransformNone.Name = "radioTextTransformNone";
            this.radioTextTransformNone.Size = new System.Drawing.Size(51, 17);
            this.radioTextTransformNone.TabIndex = 10;
            this.radioTextTransformNone.TabStop = true;
            this.radioTextTransformNone.Text = "None";
            this.radioTextTransformNone.UseVisualStyleBackColor = true;
            this.radioTextTransformNone.CheckedChanged += new System.EventHandler(this.radioTextTransformNone_CheckedChanged);
            // 
            // btnSelectRange
            // 
            this.btnSelectRange.Location = new System.Drawing.Point(306, 28);
            this.btnSelectRange.Name = "btnSelectRange";
            this.btnSelectRange.Size = new System.Drawing.Size(27, 23);
            this.btnSelectRange.TabIndex = 9;
            this.btnSelectRange.Text = "...";
            this.btnSelectRange.UseVisualStyleBackColor = true;
            this.btnSelectRange.Click += new System.EventHandler(this.btnSelectRange_Click);
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(279, 60);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(56, 20);
            this.txtDelimiter.TabIndex = 8;
            this.txtDelimiter.Text = ",";
            this.txtDelimiter.TextChanged += new System.EventHandler(this.txtDelimiter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delimiter";
            // 
            // chkAddCharacter
            // 
            this.chkAddCharacter.AutoSize = true;
            this.chkAddCharacter.Checked = true;
            this.chkAddCharacter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddCharacter.Location = new System.Drawing.Point(39, 63);
            this.chkAddCharacter.Name = "chkAddCharacter";
            this.chkAddCharacter.Size = new System.Drawing.Size(107, 17);
            this.chkAddCharacter.TabIndex = 6;
            this.chkAddCharacter.Text = "Wrap Character?";
            this.chkAddCharacter.UseVisualStyleBackColor = true;
            this.chkAddCharacter.CheckedChanged += new System.EventHandler(this.chkAddCharacter_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Results";
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(152, 60);
            this.txtCharacter.MaxLength = 1;
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(56, 20);
            this.txtCharacter.TabIndex = 3;
            this.txtCharacter.Text = "\'";
            this.txtCharacter.TextChanged += new System.EventHandler(this.txtCharacter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Range";
            // 
            // txtSelectedAddress
            // 
            this.txtSelectedAddress.Location = new System.Drawing.Point(152, 30);
            this.txtSelectedAddress.Name = "txtSelectedAddress";
            this.txtSelectedAddress.Size = new System.Drawing.Size(148, 20);
            this.txtSelectedAddress.TabIndex = 0;
            this.txtSelectedAddress.TextChanged += new System.EventHandler(this.txtSelectedAddress_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(372, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(289, 455);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "This is the tooltip title";
            // 
            // chkDistinctValues
            // 
            this.chkDistinctValues.AutoSize = true;
            this.chkDistinctValues.Location = new System.Drawing.Point(165, 98);
            this.chkDistinctValues.Name = "chkDistinctValues";
            this.chkDistinctValues.Size = new System.Drawing.Size(96, 17);
            this.chkDistinctValues.TabIndex = 16;
            this.chkDistinctValues.Text = "Distinct Values";
            this.chkDistinctValues.UseVisualStyleBackColor = true;
            this.chkDistinctValues.CheckedChanged += new System.EventHandler(this.chkDistinctValues_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(41, 399);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 17;
            // 
            // frmConcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 502);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmConcat";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Concatenate Text";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkAddCharacter;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioTextTransformToLower;
        private System.Windows.Forms.RadioButton radioTextTransformToUpper;
        private System.Windows.Forms.RadioButton radioTextTransformNone;
        private System.Windows.Forms.RichTextBox richTextResults;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.CheckBox chkCRAfterEachItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkDistinctValues;
        private System.Windows.Forms.Label lblMessage;
    }
}