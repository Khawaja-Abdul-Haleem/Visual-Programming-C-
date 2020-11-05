namespace Restaurant_POS
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbitems = new System.Windows.Forms.ComboBox();
            this.gbpayemnt = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.rbcredit = new System.Windows.Forms.RadioButton();
            this.chbraita = new System.Windows.Forms.CheckBox();
            this.chbsalad = new System.Windows.Forms.CheckBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.gbpayemnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Bill";
            // 
            // cbitems
            // 
            this.cbitems.FormattingEnabled = true;
            this.cbitems.Items.AddRange(new object[] {
            "Motton karahi Half \t950",
            "Motton Karahi Full \t1800",
            "Chicken Karahi Half\t 550",
            "Chicken Karahi Full\t 900",
            "Tikka Boti 1 Dozen \t1200",
            "Malai Boti 1 Dozen\t1200 "});
            this.cbitems.Location = new System.Drawing.Point(156, 28);
            this.cbitems.Name = "cbitems";
            this.cbitems.Size = new System.Drawing.Size(121, 21);
            this.cbitems.TabIndex = 2;
            // 
            // gbpayemnt
            // 
            this.gbpayemnt.Controls.Add(this.rbcash);
            this.gbpayemnt.Controls.Add(this.rbcredit);
            this.gbpayemnt.Location = new System.Drawing.Point(22, 135);
            this.gbpayemnt.Name = "gbpayemnt";
            this.gbpayemnt.Size = new System.Drawing.Size(255, 66);
            this.gbpayemnt.TabIndex = 3;
            this.gbpayemnt.TabStop = false;
            this.gbpayemnt.Text = "Method of Payment";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(65, 272);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Location = new System.Drawing.Point(29, 33);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(49, 17);
            this.rbcash.TabIndex = 1;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Cash";
            this.rbcash.UseVisualStyleBackColor = true;
            // 
            // rbcredit
            // 
            this.rbcredit.AutoSize = true;
            this.rbcredit.Location = new System.Drawing.Point(145, 33);
            this.rbcredit.Name = "rbcredit";
            this.rbcredit.Size = new System.Drawing.Size(76, 17);
            this.rbcredit.TabIndex = 2;
            this.rbcredit.TabStop = true;
            this.rbcredit.Text = "Credit card";
            this.rbcredit.UseVisualStyleBackColor = true;
            // 
            // chbraita
            // 
            this.chbraita.AutoSize = true;
            this.chbraita.Location = new System.Drawing.Point(99, 76);
            this.chbraita.Name = "chbraita";
            this.chbraita.Size = new System.Drawing.Size(82, 17);
            this.chbraita.TabIndex = 3;
            this.chbraita.Text = "Raita Rs 70";
            this.chbraita.UseVisualStyleBackColor = true;
            // 
            // chbsalad
            // 
            this.chbsalad.AutoSize = true;
            this.chbsalad.Location = new System.Drawing.Point(99, 112);
            this.chbsalad.Name = "chbsalad";
            this.chbsalad.Size = new System.Drawing.Size(84, 17);
            this.chbsalad.TabIndex = 4;
            this.chbsalad.Text = "Salad Rs 70";
            this.chbsalad.UseVisualStyleBackColor = true;
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(126, 224);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(100, 20);
            this.txtBill.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chbraita);
            this.Controls.Add(this.chbsalad);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.gbpayemnt);
            this.Controls.Add(this.cbitems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Restaurant Point Of Sale";
            this.gbpayemnt.ResumeLayout(false);
            this.gbpayemnt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbitems;
        private System.Windows.Forms.GroupBox gbpayemnt;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.RadioButton rbcredit;
        private System.Windows.Forms.CheckBox chbraita;
        private System.Windows.Forms.CheckBox chbsalad;
        private System.Windows.Forms.TextBox txtBill;
    }
}

