namespace Temperature_Calculator
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
            this.EnterTempLabel = new System.Windows.Forms.Label();
            this.temConvLabel = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.rbCelcius = new System.Windows.Forms.RadioButton();
            this.rbFaren = new System.Windows.Forms.RadioButton();
            this.bnConv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterTempLabel
            // 
            this.EnterTempLabel.AutoSize = true;
            this.EnterTempLabel.Location = new System.Drawing.Point(34, 61);
            this.EnterTempLabel.Name = "EnterTempLabel";
            this.EnterTempLabel.Size = new System.Drawing.Size(113, 13);
            this.EnterTempLabel.TabIndex = 0;
            this.EnterTempLabel.Text = "Enter the Temperature";
            this.EnterTempLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // temConvLabel
            // 
            this.temConvLabel.AutoSize = true;
            this.temConvLabel.Location = new System.Drawing.Point(88, 27);
            this.temConvLabel.Name = "temConvLabel";
            this.temConvLabel.Size = new System.Drawing.Size(116, 13);
            this.temConvLabel.TabIndex = 1;
            this.temConvLabel.Text = "Temperature Converter";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(153, 61);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 2;
            // 
            // rbCelcius
            // 
            this.rbCelcius.AutoSize = true;
            this.rbCelcius.Location = new System.Drawing.Point(177, 100);
            this.rbCelcius.Name = "rbCelcius";
            this.rbCelcius.Size = new System.Drawing.Size(117, 17);
            this.rbCelcius.TabIndex = 3;
            this.rbCelcius.Text = "Celcius (T-32) * 5/9";
            this.rbCelcius.UseVisualStyleBackColor = true;
            // 
            // rbFaren
            // 
            this.rbFaren.AutoSize = true;
            this.rbFaren.Checked = true;
            this.rbFaren.Location = new System.Drawing.Point(12, 100);
            this.rbFaren.Name = "rbFaren";
            this.rbFaren.Size = new System.Drawing.Size(136, 17);
            this.rbFaren.TabIndex = 4;
            this.rbFaren.TabStop = true;
            this.rbFaren.Text = "Fahrenheit (T*9/5) + 32";
            this.rbFaren.UseVisualStyleBackColor = true;
            // 
            // bnConv
            // 
            this.bnConv.Location = new System.Drawing.Point(72, 142);
            this.bnConv.Name = "bnConv";
            this.bnConv.Size = new System.Drawing.Size(75, 23);
            this.bnConv.TabIndex = 5;
            this.bnConv.Text = "Convert";
            this.bnConv.UseVisualStyleBackColor = true;
            this.bnConv.Click += new System.EventHandler(this.bnConv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(55, 189);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnConv);
            this.Controls.Add(this.rbFaren);
            this.Controls.Add(this.rbCelcius);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.temConvLabel);
            this.Controls.Add(this.EnterTempLabel);
            this.Name = "Form1";
            this.Text = "Temperature Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterTempLabel;
        private System.Windows.Forms.Label temConvLabel;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.RadioButton rbCelcius;
        private System.Windows.Forms.RadioButton rbFaren;
        private System.Windows.Forms.Button bnConv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

