namespace CheckBox_Concept
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
            this.cbSugar = new System.Windows.Forms.CheckBox();
            this.cbStrong = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSugar
            // 
            this.cbSugar.AutoSize = true;
            this.cbSugar.Location = new System.Drawing.Point(46, 47);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSugar.Size = new System.Drawing.Size(54, 17);
            this.cbSugar.TabIndex = 0;
            this.cbSugar.Text = "Sugar";
            this.cbSugar.UseVisualStyleBackColor = true;
            // 
            // cbStrong
            // 
            this.cbStrong.AutoSize = true;
            this.cbStrong.Location = new System.Drawing.Point(158, 47);
            this.cbStrong.Name = "cbStrong";
            this.cbStrong.Size = new System.Drawing.Size(57, 17);
            this.cbStrong.TabIndex = 1;
            this.cbStrong.Text = "Strong";
            this.cbStrong.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(158, 108);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(46, 108);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbStrong);
            this.Controls.Add(this.cbSugar);
            this.Name = "Form1";
            this.Text = "Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSugar;
        private System.Windows.Forms.CheckBox cbStrong;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrder;
    }
}

