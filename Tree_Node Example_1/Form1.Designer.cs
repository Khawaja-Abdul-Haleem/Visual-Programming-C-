namespace Tree_View_Control
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tb_node = new System.Windows.Forms.TextBox();
            this.btn_AddSubNode = new System.Windows.Forms.Button();
            this.btn_AddNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(179, 354);
            this.treeView1.TabIndex = 0;
            // 
            // tb_node
            // 
            this.tb_node.Location = new System.Drawing.Point(287, 44);
            this.tb_node.Name = "tb_node";
            this.tb_node.Size = new System.Drawing.Size(251, 20);
            this.tb_node.TabIndex = 1;
            // 
            // btn_AddSubNode
            // 
            this.btn_AddSubNode.Location = new System.Drawing.Point(343, 131);
            this.btn_AddSubNode.Name = "btn_AddSubNode";
            this.btn_AddSubNode.Size = new System.Drawing.Size(117, 23);
            this.btn_AddSubNode.TabIndex = 2;
            this.btn_AddSubNode.Text = "Add Sub Node";
            this.btn_AddSubNode.UseVisualStyleBackColor = true;
            this.btn_AddSubNode.Click += new System.EventHandler(this.btn_AddSubNode_Click);
            // 
            // btn_AddNode
            // 
            this.btn_AddNode.Location = new System.Drawing.Point(343, 84);
            this.btn_AddNode.Name = "btn_AddNode";
            this.btn_AddNode.Size = new System.Drawing.Size(117, 23);
            this.btn_AddNode.TabIndex = 3;
            this.btn_AddNode.Text = "Add Node";
            this.btn_AddNode.UseVisualStyleBackColor = true;
            this.btn_AddNode.Click += new System.EventHandler(this.btn_AddNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddNode);
            this.Controls.Add(this.btn_AddSubNode);
            this.Controls.Add(this.tb_node);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Tree View Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tb_node;
        private System.Windows.Forms.Button btn_AddSubNode;
        private System.Windows.Forms.Button btn_AddNode;
    }
}

