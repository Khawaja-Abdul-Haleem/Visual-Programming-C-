namespace List_Box_Concept
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.text_selected_subject = new System.Windows.Forms.ListBox();
            this.btn_single_fwd = new System.Windows.Forms.Button();
            this.btn_mul_fwd = new System.Windows.Forms.Button();
            this.btn_single_bkw = new System.Windows.Forms.Button();
            this.btn_mul_bkw = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "PF",
            "OPP",
            "VP",
            "MVC",
            "CCN",
            "DB"});
            this.listBox1.Location = new System.Drawing.Point(35, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 277);
            this.listBox1.TabIndex = 0;
            // 
            // text_selected_subject
            // 
            this.text_selected_subject.FormattingEnabled = true;
            this.text_selected_subject.Location = new System.Drawing.Point(334, 71);
            this.text_selected_subject.Name = "text_selected_subject";
            this.text_selected_subject.Size = new System.Drawing.Size(177, 277);
            this.text_selected_subject.TabIndex = 1;
            // 
            // btn_single_fwd
            // 
            this.btn_single_fwd.Location = new System.Drawing.Point(237, 100);
            this.btn_single_fwd.Name = "btn_single_fwd";
            this.btn_single_fwd.Size = new System.Drawing.Size(75, 23);
            this.btn_single_fwd.TabIndex = 2;
            this.btn_single_fwd.Text = ">";
            this.btn_single_fwd.UseVisualStyleBackColor = true;
            this.btn_single_fwd.Click += new System.EventHandler(this.btn_single_fwd_Click);
            // 
            // btn_mul_fwd
            // 
            this.btn_mul_fwd.Location = new System.Drawing.Point(237, 162);
            this.btn_mul_fwd.Name = "btn_mul_fwd";
            this.btn_mul_fwd.Size = new System.Drawing.Size(75, 23);
            this.btn_mul_fwd.TabIndex = 3;
            this.btn_mul_fwd.Text = ">>";
            this.btn_mul_fwd.UseVisualStyleBackColor = true;
            this.btn_mul_fwd.Click += new System.EventHandler(this.btn_mul_fwd_Click);
            // 
            // btn_single_bkw
            // 
            this.btn_single_bkw.Location = new System.Drawing.Point(237, 224);
            this.btn_single_bkw.Name = "btn_single_bkw";
            this.btn_single_bkw.Size = new System.Drawing.Size(75, 23);
            this.btn_single_bkw.TabIndex = 4;
            this.btn_single_bkw.Text = "<";
            this.btn_single_bkw.UseVisualStyleBackColor = true;
            this.btn_single_bkw.Click += new System.EventHandler(this.btn_single_bkw_Click);
            // 
            // btn_mul_bkw
            // 
            this.btn_mul_bkw.Location = new System.Drawing.Point(237, 286);
            this.btn_mul_bkw.Name = "btn_mul_bkw";
            this.btn_mul_bkw.Size = new System.Drawing.Size(75, 23);
            this.btn_mul_bkw.TabIndex = 5;
            this.btn_mul_bkw.Text = "<<";
            this.btn_mul_bkw.UseVisualStyleBackColor = true;
            this.btn_mul_bkw.Click += new System.EventHandler(this.btn_mul_bkw_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(532, 162);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(96, 85);
            this.btn_exit.TabIndex = 6;
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
            this.Controls.Add(this.btn_mul_bkw);
            this.Controls.Add(this.btn_single_bkw);
            this.Controls.Add(this.btn_mul_fwd);
            this.Controls.Add(this.btn_single_fwd);
            this.Controls.Add(this.text_selected_subject);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "ListBox Concept";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox text_selected_subject;
        private System.Windows.Forms.Button btn_single_fwd;
        private System.Windows.Forms.Button btn_mul_fwd;
        private System.Windows.Forms.Button btn_single_bkw;
        private System.Windows.Forms.Button btn_mul_bkw;
        private System.Windows.Forms.Button btn_exit;
    }
}

