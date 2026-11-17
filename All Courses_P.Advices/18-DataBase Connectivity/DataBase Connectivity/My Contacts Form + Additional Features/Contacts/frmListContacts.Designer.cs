namespace Contacts
{
    partial class frmListContacts
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
            System.Windows.Forms.Button btnAddNewContact;
            System.Windows.Forms.Button btnShowAllCountries;
            System.Windows.Forms.Button btnSearch;
            this.dgvAllContacts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAddNewContact = new System.Windows.Forms.Button();
            btnShowAllCountries = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContacts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewContact
            // 
            btnAddNewContact.Location = new System.Drawing.Point(1175, 27);
            btnAddNewContact.Margin = new System.Windows.Forms.Padding(4);
            btnAddNewContact.Name = "btnAddNewContact";
            btnAddNewContact.Size = new System.Drawing.Size(199, 76);
            btnAddNewContact.TabIndex = 1;
            btnAddNewContact.Text = "Add New Contact";
            btnAddNewContact.UseVisualStyleBackColor = true;
            btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // btnShowAllCountries
            // 
            btnShowAllCountries.BackColor = System.Drawing.Color.Transparent;
            btnShowAllCountries.Location = new System.Drawing.Point(33, 27);
            btnShowAllCountries.Margin = new System.Windows.Forms.Padding(4);
            btnShowAllCountries.Name = "btnShowAllCountries";
            btnShowAllCountries.Size = new System.Drawing.Size(199, 76);
            btnShowAllCountries.TabIndex = 2;
            btnShowAllCountries.Text = "Show All Countries";
            btnShowAllCountries.UseVisualStyleBackColor = false;
            btnShowAllCountries.Click += new System.EventHandler(this.btnShowAllCountries_Click);
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(612, 27);
            btnSearch.Margin = new System.Windows.Forms.Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(199, 76);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search for users by name";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAllContacts
            // 
            this.dgvAllContacts.AllowUserToAddRows = false;
            this.dgvAllContacts.AllowUserToDeleteRows = false;
            this.dgvAllContacts.AllowUserToOrderColumns = true;
            this.dgvAllContacts.AllowUserToResizeRows = false;
            this.dgvAllContacts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAllContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAllContacts.CausesValidation = false;
            this.dgvAllContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllContacts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllContacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllContacts.GridColor = System.Drawing.SystemColors.Info;
            this.dgvAllContacts.Location = new System.Drawing.Point(11, 139);
            this.dgvAllContacts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllContacts.Name = "dgvAllContacts";
            this.dgvAllContacts.ReadOnly = true;
            this.dgvAllContacts.RowHeadersWidth = 100;
            this.dgvAllContacts.Size = new System.Drawing.Size(1363, 248);
            this.dgvAllContacts.TabIndex = 0;
            this.dgvAllContacts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllContacts_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 68);
            this.contextMenuStrip1.Tag = "";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmListContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 683);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnShowAllCountries);
            this.Controls.Add(btnAddNewContact);
            this.Controls.Add(this.dgvAllContacts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListContacts";
            this.Text = "frmListContacts";
            this.Load += new System.EventHandler(this.frmListContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllContacts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllContacts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}