namespace MyFirstWinFormsProject
{
    partial class frmTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ahmed");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ali");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Boys", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Huda");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Alia");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Girls", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("a", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Girl.png");
            this.imageList1.Images.SetKeyName(1, "Boy.png");
            this.imageList1.Images.SetKeyName(2, "Ascii-codes-table.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(109, 44);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Boy1";
            treeNode1.Text = "Ahmed";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Boy2";
            treeNode2.Text = "Ali";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Boys";
            treeNode3.Text = "Boys";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Girl1";
            treeNode4.SelectedImageKey = "Girl.png";
            treeNode4.Text = "Huda";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Girl2";
            treeNode5.SelectedImageKey = "Girl.png";
            treeNode5.Text = "Alia";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Girls";
            treeNode6.SelectedImageKey = "Girl.png";
            treeNode6.Text = "Girls";
            treeNode7.ImageKey = "Ascii-codes-table.png";
            treeNode7.Name = "Node3";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Node3";
            treeNode8.ImageKey = "Ascii-codes-table.png";
            treeNode8.Name = "Node4";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Node4";
            treeNode9.ImageKey = "Ascii-codes-table.png";
            treeNode9.Name = "Node1";
            treeNode9.SelectedImageIndex = 2;
            treeNode9.Text = "Node1";
            treeNode10.ImageKey = "Ascii-codes-table.png";
            treeNode10.Name = "Node2";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Text = "Node2";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "a";
            treeNode11.SelectedImageIndex = 2;
            treeNode11.Text = "a";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode11});
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(630, 501);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 647);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTreeView";
            this.Text = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}