namespace List_Box_Example
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_rem = new System.Windows.Forms.Button();
            this.lb_subject = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name of product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(243, 109);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(360, 109);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(75, 23);
            this.btn_rem.TabIndex = 3;
            this.btn_rem.Text = "Remove";
            this.btn_rem.UseVisualStyleBackColor = true;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // lb_subject
            // 
            this.lb_subject.FormattingEnabled = true;
            this.lb_subject.Location = new System.Drawing.Point(186, 149);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(153, 186);
            this.lb_subject.TabIndex = 4;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(262, 397);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(360, 397);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remove Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ListBox_example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.ListBox lb_subject;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
    }
}

