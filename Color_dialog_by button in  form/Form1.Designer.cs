namespace Color_Dialog
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
            this.gb_back = new System.Windows.Forms.GroupBox();
            this.btn_gray = new System.Windows.Forms.RadioButton();
            this.btn_blue = new System.Windows.Forms.RadioButton();
            this.btn_green = new System.Windows.Forms.RadioButton();
            this.btn_red = new System.Windows.Forms.RadioButton();
            this.gb_fore = new System.Windows.Forms.GroupBox();
            this.btn_black = new System.Windows.Forms.RadioButton();
            this.btn_white = new System.Windows.Forms.RadioButton();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gb_back.SuspendLayout();
            this.gb_fore.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_back
            // 
            this.gb_back.Controls.Add(this.btn_gray);
            this.gb_back.Controls.Add(this.btn_blue);
            this.gb_back.Controls.Add(this.btn_green);
            this.gb_back.Controls.Add(this.btn_red);
            this.gb_back.Location = new System.Drawing.Point(29, 12);
            this.gb_back.Name = "gb_back";
            this.gb_back.Size = new System.Drawing.Size(431, 142);
            this.gb_back.TabIndex = 0;
            this.gb_back.TabStop = false;
            this.gb_back.Text = "BACK COLOR";
            // 
            // btn_gray
            // 
            this.btn_gray.AutoSize = true;
            this.btn_gray.Location = new System.Drawing.Point(247, 95);
            this.btn_gray.Name = "btn_gray";
            this.btn_gray.Size = new System.Drawing.Size(55, 17);
            this.btn_gray.TabIndex = 3;
            this.btn_gray.TabStop = true;
            this.btn_gray.Text = "GRAY";
            this.btn_gray.UseVisualStyleBackColor = true;
            // 
            // btn_blue
            // 
            this.btn_blue.AutoSize = true;
            this.btn_blue.Location = new System.Drawing.Point(107, 95);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(53, 17);
            this.btn_blue.TabIndex = 2;
            this.btn_blue.TabStop = true;
            this.btn_blue.Text = "BLUE";
            this.btn_blue.UseVisualStyleBackColor = true;
            // 
            // btn_green
            // 
            this.btn_green.AutoSize = true;
            this.btn_green.Location = new System.Drawing.Point(247, 19);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(63, 17);
            this.btn_green.TabIndex = 1;
            this.btn_green.TabStop = true;
            this.btn_green.Text = "GREEN";
            this.btn_green.UseVisualStyleBackColor = true;
            // 
            // btn_red
            // 
            this.btn_red.AutoSize = true;
            this.btn_red.Location = new System.Drawing.Point(107, 19);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(48, 17);
            this.btn_red.TabIndex = 0;
            this.btn_red.TabStop = true;
            this.btn_red.Text = "RED";
            this.btn_red.UseVisualStyleBackColor = true;
            // 
            // gb_fore
            // 
            this.gb_fore.Controls.Add(this.btn_black);
            this.gb_fore.Controls.Add(this.btn_white);
            this.gb_fore.Location = new System.Drawing.Point(29, 175);
            this.gb_fore.Name = "gb_fore";
            this.gb_fore.Size = new System.Drawing.Size(431, 109);
            this.gb_fore.TabIndex = 0;
            this.gb_fore.TabStop = false;
            this.gb_fore.Text = "FORECOLOR";
            // 
            // btn_black
            // 
            this.btn_black.AutoSize = true;
            this.btn_black.Location = new System.Drawing.Point(107, 50);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(59, 17);
            this.btn_black.TabIndex = 4;
            this.btn_black.TabStop = true;
            this.btn_black.Text = "BLACK";
            this.btn_black.UseVisualStyleBackColor = true;
            // 
            // btn_white
            // 
            this.btn_white.AutoSize = true;
            this.btn_white.Location = new System.Drawing.Point(247, 50);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(61, 17);
            this.btn_white.TabIndex = 5;
            this.btn_white.TabStop = true;
            this.btn_white.Text = "WHITE";
            this.btn_white.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(84, 304);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(212, 304);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gb_fore);
            this.Controls.Add(this.gb_back);
            this.Name = "Form1";
            this.Text = "Color Dialog";
            this.gb_back.ResumeLayout(false);
            this.gb_back.PerformLayout();
            this.gb_fore.ResumeLayout(false);
            this.gb_fore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_back;
        private System.Windows.Forms.RadioButton btn_gray;
        private System.Windows.Forms.RadioButton btn_blue;
        private System.Windows.Forms.RadioButton btn_green;
        private System.Windows.Forms.RadioButton btn_red;
        private System.Windows.Forms.GroupBox gb_fore;
        private System.Windows.Forms.RadioButton btn_black;
        private System.Windows.Forms.RadioButton btn_white;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_exit;
    }
}

