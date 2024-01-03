namespace Lab6
{
    partial class FieldExceptionForm
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblField = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.TextBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 13);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(69, 17);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message:";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(89, 13);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(328, 22);
            this.txtMsg.TabIndex = 1;
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(13, 44);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(42, 17);
            this.lblField.TabIndex = 2;
            this.lblField.Text = "Field:";
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(89, 44);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(328, 22);
            this.txtField.TabIndex = 3;
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(16, 77);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(48, 17);
            this.lblVal.TabIndex = 4;
            this.lblVal.Text = "Value:";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(89, 77);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(328, 22);
            this.txtVal.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(172, 118);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 43);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FieldExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 173);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lblMsg);
            this.Name = "FieldExceptionForm";
            this.Text = "FieldExceptionForm";
            this.Load += new System.EventHandler(this.FieldExceptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Button btnOk;
    }
}