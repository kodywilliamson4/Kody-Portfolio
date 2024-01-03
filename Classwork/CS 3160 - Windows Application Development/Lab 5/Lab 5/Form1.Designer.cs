namespace Lab_5
{
    partial class Form1
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
            this.lstAcc = new System.Windows.Forms.ListBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.lblMess = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.cmbTrans = new System.Windows.Forms.ComboBox();
            this.lblTrans = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnInterest = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAcc
            // 
            this.lstAcc.FormattingEnabled = true;
            this.lstAcc.ItemHeight = 16;
            this.lstAcc.Location = new System.Drawing.Point(12, 30);
            this.lstAcc.Name = "lstAcc";
            this.lstAcc.Size = new System.Drawing.Size(312, 212);
            this.lstAcc.TabIndex = 0;
            this.lstAcc.SelectedIndexChanged += new System.EventHandler(this.lstAcc_SelectedIndexChanged);
            // 
            // txtMess
            // 
            this.txtMess.Enabled = false;
            this.txtMess.Location = new System.Drawing.Point(12, 276);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(312, 22);
            this.txtMess.TabIndex = 1;
            // 
            // lblMess
            // 
            this.lblMess.AutoSize = true;
            this.lblMess.Location = new System.Drawing.Point(13, 253);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(65, 17);
            this.lblMess.TabIndex = 2;
            this.lblMess.Text = "Message";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(13, 7);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(66, 17);
            this.lblAcc.TabIndex = 3;
            this.lblAcc.Text = "Accounts";
            // 
            // cmbTrans
            // 
            this.cmbTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrans.FormattingEnabled = true;
            this.cmbTrans.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cmbTrans.Location = new System.Drawing.Point(349, 30);
            this.cmbTrans.Name = "cmbTrans";
            this.cmbTrans.Size = new System.Drawing.Size(195, 24);
            this.cmbTrans.TabIndex = 4;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(349, 7);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(83, 17);
            this.lblTrans.TabIndex = 5;
            this.lblTrans.Text = "&Transaction";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(349, 94);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(195, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(352, 71);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "&Amount";
            // 
            // btnInterest
            // 
            this.btnInterest.Location = new System.Drawing.Point(349, 162);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(195, 35);
            this.btnInterest.TabIndex = 8;
            this.btnInterest.Text = "Add Interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(349, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(349, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 347);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInterest);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.cmbTrans);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblMess);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.lstAcc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAcc;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.ComboBox cmbTrans;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}

