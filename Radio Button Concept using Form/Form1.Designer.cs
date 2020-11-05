namespace Radio_Button_Concept
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
            this.gbBack = new System.Windows.Forms.GroupBox();
            this.gbFront = new System.Windows.Forms.GroupBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbBack.SuspendLayout();
            this.gbFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBack
            // 
            this.gbBack.Controls.Add(this.rbRed);
            this.gbBack.Controls.Add(this.rbGreen);
            this.gbBack.Controls.Add(this.rbBlue);
            this.gbBack.Controls.Add(this.rbGray);
            this.gbBack.Location = new System.Drawing.Point(50, 27);
            this.gbBack.Name = "gbBack";
            this.gbBack.Size = new System.Drawing.Size(369, 119);
            this.gbBack.TabIndex = 0;
            this.gbBack.TabStop = false;
            this.gbBack.Text = "BackColor";
            // 
            // gbFront
            // 
            this.gbFront.Controls.Add(this.rbWhite);
            this.gbFront.Controls.Add(this.rbBlack);
            this.gbFront.Location = new System.Drawing.Point(50, 179);
            this.gbFront.Name = "gbFront";
            this.gbFront.Size = new System.Drawing.Size(369, 119);
            this.gbFront.TabIndex = 0;
            this.gbFront.TabStop = false;
            this.gbFront.Text = "ForeColor";
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(47, 40);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(199, 40);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(47, 82);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Location = new System.Drawing.Point(199, 82);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(47, 17);
            this.rbGray.TabIndex = 4;
            this.rbGray.TabStop = true;
            this.rbGray.Text = "Gray";
            this.rbGray.UseVisualStyleBackColor = true;
            this.rbGray.CheckedChanged += new System.EventHandler(this.rbGray_CheckedChanged);
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(80, 42);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(53, 17);
            this.rbWhite.TabIndex = 5;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rbWhite_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Checked = true;
            this.rbBlack.Location = new System.Drawing.Point(80, 81);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(52, 17);
            this.rbBlack.TabIndex = 6;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(182, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbFront);
            this.Controls.Add(this.gbBack);
            this.Name = "Form1";
            this.Text = "Color Changer";
            this.gbBack.ResumeLayout(false);
            this.gbBack.PerformLayout();
            this.gbFront.ResumeLayout(false);
            this.gbFront.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBack;
        private System.Windows.Forms.GroupBox gbFront;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGray;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.Button btnExit;
    }
}

