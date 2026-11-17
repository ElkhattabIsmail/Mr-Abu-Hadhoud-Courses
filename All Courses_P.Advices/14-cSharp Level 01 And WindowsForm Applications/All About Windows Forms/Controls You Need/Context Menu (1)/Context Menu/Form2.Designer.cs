namespace MDI_Sample
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmFormat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1.SuspendLayout();
            this.cmFormat.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 94);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.cmFormat;
            this.textBox1.Location = new System.Drawing.Point(55, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 22);
            this.textBox1.TabIndex = 1;
            // 
            // cmFormat
            // 
            this.cmFormat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChangeColor,
            this.tsmChangeFont,
            this.tsmClear});
            this.cmFormat.Name = "cmFormat";
            this.cmFormat.Size = new System.Drawing.Size(193, 94);
            this.cmFormat.Opening += new System.ComponentModel.CancelEventHandler(this.cmFormat_Opening);
            // 
            // tsmChangeColor
            // 
            this.tsmChangeColor.Name = "tsmChangeColor";
            this.tsmChangeColor.Size = new System.Drawing.Size(192, 30);
            this.tsmChangeColor.Text = "Change Color";
            this.tsmChangeColor.Click += new System.EventHandler(this.tsmChangeColor_Click);
            // 
            // tsmChangeFont
            // 
            this.tsmChangeFont.Name = "tsmChangeFont";
            this.tsmChangeFont.Size = new System.Drawing.Size(192, 30);
            this.tsmChangeFont.Text = "Change Font";
            this.tsmChangeFont.Click += new System.EventHandler(this.tsmChangeFont_Click);
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(192, 30);
            this.tsmClear.Text = "Clear";
            this.tsmClear.Click += new System.EventHandler(this.tsmClear_Click);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(509, 52);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            treeNode11.Name = "Node7";
            treeNode11.Text = "Node7";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Node1";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Node2";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Node0";
            treeNode15.Name = "Node4";
            treeNode15.Text = "Node4";
            treeNode16.Name = "Node1";
            treeNode16.Text = "Node1";
            treeNode17.Name = "Node5";
            treeNode17.Text = "Node5";
            treeNode18.Name = "Node2";
            treeNode18.Text = "Node2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(421, 298);
            this.treeView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.ContextMenuStrip = this.cmFormat;
            this.textBox2.Location = new System.Drawing.Point(59, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 22);
            this.textBox2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(445, 379);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 88);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 81);
            this.button2.TabIndex = 0;
            this.button2.Text = "Purple";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 82);
            this.button3.TabIndex = 1;
            this.button3.Text = "Red";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 81);
            this.button4.TabIndex = 2;
            this.button4.Text = "Bleu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 81);
            this.button5.TabIndex = 3;
            this.button5.Text = "Yellow";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.cmFormat.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip cmFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeColor;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeFont;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem tsmClear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}