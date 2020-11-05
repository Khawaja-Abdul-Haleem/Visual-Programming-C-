namespace Combo_Box_concept_using_form
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
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbValRemove = new System.Windows.Forms.RadioButton();
            this.rbIndexRemove = new System.Windows.Forms.RadioButton();
            this.bnRemSub = new System.Windows.Forms.Button();
            this.txtRemoveItems = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSubjects
            // 
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Items.AddRange(new object[] {
            "Programming Fundamentals",
            "DataBase",
            "Virual Programming ",
            "Computer Networks",
            "Projects"});
            this.cbSubjects.Location = new System.Drawing.Point(12, 53);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(179, 21);
            this.cbSubjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subjects";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(15, 107);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Items";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(116, 107);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 3;
            this.btnIndex.Text = "Show Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(219, 107);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Location = new System.Drawing.Point(15, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD Subjects";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(28, 31);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(128, 20);
            this.txtAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemoveItems);
            this.groupBox2.Controls.Add(this.bnRemSub);
            this.groupBox2.Controls.Add(this.rbIndexRemove);
            this.groupBox2.Controls.Add(this.rbValRemove);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Subjects";
            // 
            // rbValRemove
            // 
            this.rbValRemove.AutoSize = true;
            this.rbValRemove.Location = new System.Drawing.Point(137, 39);
            this.rbValRemove.Name = "rbValRemove";
            this.rbValRemove.Size = new System.Drawing.Size(67, 17);
            this.rbValRemove.TabIndex = 0;
            this.rbValRemove.TabStop = true;
            this.rbValRemove.Text = "By Value";
            this.rbValRemove.UseVisualStyleBackColor = true;
            // 
            // rbIndexRemove
            // 
            this.rbIndexRemove.AutoSize = true;
            this.rbIndexRemove.Location = new System.Drawing.Point(19, 39);
            this.rbIndexRemove.Name = "rbIndexRemove";
            this.rbIndexRemove.Size = new System.Drawing.Size(66, 17);
            this.rbIndexRemove.TabIndex = 1;
            this.rbIndexRemove.TabStop = true;
            this.rbIndexRemove.Text = "By Index";
            this.rbIndexRemove.UseVisualStyleBackColor = true;
            this.rbIndexRemove.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bnRemSub
            // 
            this.bnRemSub.Location = new System.Drawing.Point(137, 62);
            this.bnRemSub.Name = "bnRemSub";
            this.bnRemSub.Size = new System.Drawing.Size(75, 23);
            this.bnRemSub.TabIndex = 2;
            this.bnRemSub.Text = "Remove";
            this.bnRemSub.UseVisualStyleBackColor = true;
            this.bnRemSub.Click += new System.EventHandler(this.bnRemSub_Click);
            // 
            // txtRemoveItems
            // 
            this.txtRemoveItems.Location = new System.Drawing.Point(19, 65);
            this.txtRemoveItems.Name = "txtRemoveItems";
            this.txtRemoveItems.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveItems.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSubjects);
            this.Name = "Form1";
            this.Text = "Subject Enroller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRemoveItems;
        private System.Windows.Forms.Button bnRemSub;
        private System.Windows.Forms.RadioButton rbIndexRemove;
        private System.Windows.Forms.RadioButton rbValRemove;
    }
}

