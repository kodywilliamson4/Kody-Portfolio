namespace Lab_2
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
            this.radSandwich = new System.Windows.Forms.RadioButton();
            this.radFries = new System.Windows.Forms.RadioButton();
            this.radSoft = new System.Windows.Forms.RadioButton();
            this.radWater = new System.Windows.Forms.RadioButton();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbQuant = new System.Windows.Forms.ComboBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpItems.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSandwich
            // 
            this.radSandwich.AutoSize = true;
            this.radSandwich.Location = new System.Drawing.Point(6, 26);
            this.radSandwich.Name = "radSandwich";
            this.radSandwich.Size = new System.Drawing.Size(102, 24);
            this.radSandwich.TabIndex = 1;
            this.radSandwich.Text = "Sandwich";
            this.radSandwich.UseVisualStyleBackColor = true;
            this.radSandwich.CheckedChanged += new System.EventHandler(this.radSandwich_CheckedChanged);
            // 
            // radFries
            // 
            this.radFries.AutoSize = true;
            this.radFries.Location = new System.Drawing.Point(6, 56);
            this.radFries.Name = "radFries";
            this.radFries.Size = new System.Drawing.Size(68, 24);
            this.radFries.TabIndex = 2;
            this.radFries.Text = "Fries";
            this.radFries.UseVisualStyleBackColor = true;
            this.radFries.CheckedChanged += new System.EventHandler(this.radFries_CheckedChanged);
            // 
            // radSoft
            // 
            this.radSoft.AutoSize = true;
            this.radSoft.Location = new System.Drawing.Point(6, 86);
            this.radSoft.Name = "radSoft";
            this.radSoft.Size = new System.Drawing.Size(105, 24);
            this.radSoft.TabIndex = 3;
            this.radSoft.Text = "Soft Drink";
            this.radSoft.UseVisualStyleBackColor = true;
            this.radSoft.CheckedChanged += new System.EventHandler(this.radSoft_CheckedChanged);
            // 
            // radWater
            // 
            this.radWater.AutoSize = true;
            this.radWater.Location = new System.Drawing.Point(6, 116);
            this.radWater.Name = "radWater";
            this.radWater.Size = new System.Drawing.Size(75, 24);
            this.radWater.TabIndex = 4;
            this.radWater.Text = "Water";
            this.radWater.UseVisualStyleBackColor = true;
            this.radWater.CheckedChanged += new System.EventHandler(this.radWater_CheckedChanged);
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.radSandwich);
            this.grpItems.Controls.Add(this.radWater);
            this.grpItems.Controls.Add(this.radFries);
            this.grpItems.Controls.Add(this.radSoft);
            this.grpItems.Location = new System.Drawing.Point(50, 32);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(200, 149);
            this.grpItems.TabIndex = 5;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            this.grpItems.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(294, 32);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(200, 130);
            this.grpSize.TabIndex = 6;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Enabled = false;
            this.radLarge.Location = new System.Drawing.Point(7, 88);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(73, 24);
            this.radLarge.TabIndex = 2;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Enabled = false;
            this.radMedium.Location = new System.Drawing.Point(7, 58);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(89, 24);
            this.radMedium.TabIndex = 1;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Enabled = false;
            this.radSmall.Location = new System.Drawing.Point(7, 27);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(72, 24);
            this.radSmall.TabIndex = 0;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(529, 32);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(71, 20);
            this.lblQuant.TabIndex = 7;
            this.lblQuant.Text = "Quantity";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(533, 96);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(51, 20);
            this.lblTot.TabIndex = 8;
            this.lblTot.Text = "Total";
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(540, 124);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbQuant
            // 
            this.cmbQuant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuant.Enabled = false;
            this.cmbQuant.FormattingEnabled = true;
            this.cmbQuant.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuant.Location = new System.Drawing.Point(533, 57);
            this.cmbQuant.Name = "cmbQuant";
            this.cmbQuant.Size = new System.Drawing.Size(121, 28);
            this.cmbQuant.TabIndex = 10;
            // 
            // lstOrder
            // 
            this.lstOrder.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 20;
            this.lstOrder.Location = new System.Drawing.Point(50, 187);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(604, 124);
            this.lstOrder.TabIndex = 11;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Enabled = false;
            this.btnOrder.Location = new System.Drawing.Point(200, 316);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(146, 44);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(379, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 44);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 384);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.cmbQuant);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSandwich;
        private System.Windows.Forms.RadioButton radFries;
        private System.Windows.Forms.RadioButton radSoft;
        private System.Windows.Forms.RadioButton radWater;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbQuant;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpItems;
    }
}

