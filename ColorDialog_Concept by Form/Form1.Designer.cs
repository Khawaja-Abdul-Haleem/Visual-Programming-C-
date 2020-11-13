namespace ColorDialog_concept
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bg = new System.Windows.Forms.Button();
            this.btn_fc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_fc);
            this.groupBox1.Controls.Add(this.btn_bg);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Changer";
            // 
            // btn_bg
            // 
            this.btn_bg.Location = new System.Drawing.Point(16, 65);
            this.btn_bg.Name = "btn_bg";
            this.btn_bg.Size = new System.Drawing.Size(97, 96);
            this.btn_bg.TabIndex = 0;
            this.btn_bg.Text = "Change BackGround Color";
            this.btn_bg.UseVisualStyleBackColor = true;
            this.btn_bg.Click += new System.EventHandler(this.btn_bg_Click);
            // 
            // btn_fc
            // 
            this.btn_fc.Location = new System.Drawing.Point(154, 65);
            this.btn_fc.Name = "btn_fc";
            this.btn_fc.Size = new System.Drawing.Size(97, 96);
            this.btn_fc.TabIndex = 1;
            this.btn_fc.Text = "Change ForeColor";
            this.btn_fc.UseVisualStyleBackColor = true;
            this.btn_fc.Click += new System.EventHandler(this.btn_fc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(295, 65);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 96);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Color Dialog";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_fc;
        private System.Windows.Forms.Button btn_bg;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

