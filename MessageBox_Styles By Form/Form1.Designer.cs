namespace MessageBox_Styles
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
            this.btn_mb_simple = new System.Windows.Forms.Button();
            this.btn_mb_title = new System.Windows.Forms.Button();
            this.btn_mb_title_btn = new System.Windows.Forms.Button();
            this.btn_title_icon = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mb_simple
            // 
            this.btn_mb_simple.Location = new System.Drawing.Point(42, 42);
            this.btn_mb_simple.Name = "btn_mb_simple";
            this.btn_mb_simple.Size = new System.Drawing.Size(193, 40);
            this.btn_mb_simple.TabIndex = 0;
            this.btn_mb_simple.Text = "Simple MessageBox";
            this.btn_mb_simple.UseVisualStyleBackColor = true;
            this.btn_mb_simple.Click += new System.EventHandler(this.btn_mb_simple_Click);
            // 
            // btn_mb_title
            // 
            this.btn_mb_title.Location = new System.Drawing.Point(42, 110);
            this.btn_mb_title.Name = "btn_mb_title";
            this.btn_mb_title.Size = new System.Drawing.Size(193, 40);
            this.btn_mb_title.TabIndex = 1;
            this.btn_mb_title.Text = "MessageBox with Title";
            this.btn_mb_title.UseVisualStyleBackColor = true;
            this.btn_mb_title.Click += new System.EventHandler(this.btn_mb_title_Click);
            // 
            // btn_mb_title_btn
            // 
            this.btn_mb_title_btn.Location = new System.Drawing.Point(42, 178);
            this.btn_mb_title_btn.Name = "btn_mb_title_btn";
            this.btn_mb_title_btn.Size = new System.Drawing.Size(193, 40);
            this.btn_mb_title_btn.TabIndex = 2;
            this.btn_mb_title_btn.Text = "MessageBox With title, Buttons";
            this.btn_mb_title_btn.UseVisualStyleBackColor = true;
            this.btn_mb_title_btn.Click += new System.EventHandler(this.btn_mb_title_btn_Click);
            // 
            // btn_title_icon
            // 
            this.btn_title_icon.Location = new System.Drawing.Point(42, 246);
            this.btn_title_icon.Name = "btn_title_icon";
            this.btn_title_icon.Size = new System.Drawing.Size(193, 40);
            this.btn_title_icon.TabIndex = 3;
            this.btn_title_icon.Text = "MessageBox with Tile, Buttons, Icons";
            this.btn_title_icon.UseVisualStyleBackColor = true;
            this.btn_title_icon.Click += new System.EventHandler(this.btn_title_icon_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(342, 59);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(92, 91);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_title_icon);
            this.Controls.Add(this.btn_mb_title_btn);
            this.Controls.Add(this.btn_mb_title);
            this.Controls.Add(this.btn_mb_simple);
            this.Name = "Form1";
            this.Text = "MessageBox Styles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mb_simple;
        private System.Windows.Forms.Button btn_mb_title;
        private System.Windows.Forms.Button btn_mb_title_btn;
        private System.Windows.Forms.Button btn_title_icon;
        private System.Windows.Forms.Button btn_exit;
    }
}

