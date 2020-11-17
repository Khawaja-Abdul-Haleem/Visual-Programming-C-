namespace DateTime_Picker_Concept
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_date = new System.Windows.Forms.Button();
            this.btn_time = new System.Windows.Forms.Button();
            this.btn_break_ap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.gb_month = new System.Windows.Forms.GroupBox();
            this.gb_age = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_new_month = new System.Windows.Forms.TextBox();
            this.tb_new_date = new System.Windows.Forms.TextBox();
            this.btn_add_month = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gb_month.SuspendLayout();
            this.gb_age.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btn_date
            // 
            this.btn_date.Location = new System.Drawing.Point(29, 62);
            this.btn_date.Name = "btn_date";
            this.btn_date.Size = new System.Drawing.Size(75, 23);
            this.btn_date.TabIndex = 1;
            this.btn_date.Text = "Show Date";
            this.btn_date.UseVisualStyleBackColor = true;
            this.btn_date.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_time
            // 
            this.btn_time.Location = new System.Drawing.Point(128, 62);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(75, 23);
            this.btn_time.TabIndex = 2;
            this.btn_time.Text = "Show Time";
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // btn_break_ap
            // 
            this.btn_break_ap.Location = new System.Drawing.Point(227, 62);
            this.btn_break_ap.Name = "btn_break_ap";
            this.btn_break_ap.Size = new System.Drawing.Size(75, 23);
            this.btn_break_ap.TabIndex = 3;
            this.btn_break_ap.Text = "Break Apart";
            this.btn_break_ap.UseVisualStyleBackColor = true;
            this.btn_break_ap.Click += new System.EventHandler(this.btn_break_ap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year";
            // 
            // tb_day
            // 
            this.tb_day.Location = new System.Drawing.Point(140, 114);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(147, 20);
            this.tb_day.TabIndex = 8;
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(140, 142);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(147, 20);
            this.tb_month.TabIndex = 9;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(140, 170);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(147, 20);
            this.tb_date.TabIndex = 10;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(140, 198);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(147, 20);
            this.tb_year.TabIndex = 11;
            // 
            // gb_month
            // 
            this.gb_month.Controls.Add(this.btn_add_month);
            this.gb_month.Controls.Add(this.tb_new_month);
            this.gb_month.Controls.Add(this.tb_new_date);
            this.gb_month.Controls.Add(this.label5);
            this.gb_month.Controls.Add(this.label6);
            this.gb_month.Location = new System.Drawing.Point(29, 237);
            this.gb_month.Name = "gb_month";
            this.gb_month.Size = new System.Drawing.Size(267, 159);
            this.gb_month.TabIndex = 12;
            this.gb_month.TabStop = false;
            this.gb_month.Text = "Add Months";
            // 
            // gb_age
            // 
            this.gb_age.Controls.Add(this.label7);
            this.gb_age.Controls.Add(this.tb_age);
            this.gb_age.Controls.Add(this.btn_calculate);
            this.gb_age.Controls.Add(this.dateTimePicker2);
            this.gb_age.Location = new System.Drawing.Point(332, 237);
            this.gb_age.Name = "gb_age";
            this.gb_age.Size = new System.Drawing.Size(328, 159);
            this.gb_age.TabIndex = 0;
            this.gb_age.TabStop = false;
            this.gb_age.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "New Date";
            // 
            // tb_new_month
            // 
            this.tb_new_month.Location = new System.Drawing.Point(69, 25);
            this.tb_new_month.Name = "tb_new_month";
            this.tb_new_month.Size = new System.Drawing.Size(189, 20);
            this.tb_new_month.TabIndex = 13;
            // 
            // tb_new_date
            // 
            this.tb_new_date.Location = new System.Drawing.Point(69, 113);
            this.tb_new_date.Name = "tb_new_date";
            this.tb_new_date.Size = new System.Drawing.Size(189, 20);
            this.tb_new_date.TabIndex = 14;
            // 
            // btn_add_month
            // 
            this.btn_add_month.Location = new System.Drawing.Point(127, 66);
            this.btn_add_month.Name = "btn_add_month";
            this.btn_add_month.Size = new System.Drawing.Size(75, 23);
            this.btn_add_month.TabIndex = 15;
            this.btn_add_month.Text = "Add Month";
            this.btn_add_month.UseVisualStyleBackColor = true;
            this.btn_add_month.Click += new System.EventHandler(this.btn_add_month_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(291, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(117, 66);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(95, 120);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(215, 20);
            this.tb_age.TabIndex = 2;
            this.tb_age.Text = "l";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Age in Days";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(288, 392);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 13;
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
            this.Controls.Add(this.gb_age);
            this.Controls.Add(this.gb_month);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.tb_day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_break_ap);
            this.Controls.Add(this.btn_time);
            this.Controls.Add(this.btn_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "DateTime Picker";
            this.gb_month.ResumeLayout(false);
            this.gb_month.PerformLayout();
            this.gb_age.ResumeLayout(false);
            this.gb_age.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_date;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.Button btn_break_ap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.GroupBox gb_month;
        private System.Windows.Forms.Button btn_add_month;
        private System.Windows.Forms.TextBox tb_new_month;
        private System.Windows.Forms.TextBox tb_new_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_exit;
    }
}

