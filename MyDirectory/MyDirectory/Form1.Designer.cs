﻿
namespace MyDirectory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Name");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Weight");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Type");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Sort by", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("File1");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("File2");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Folder", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.Create_bt = new System.Windows.Forms.Button();
            this.Rename_bt = new System.Windows.Forms.Button();
            this.Delete_bt = new System.Windows.Forms.Button();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.SortPanel = new System.Windows.Forms.Panel();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Duplicate_bt = new System.Windows.Forms.Button();
            this.Search_ListView = new System.Windows.Forms.ListView();
            this.DownPanel = new System.Windows.Forms.Panel();
            this.search_label = new System.Windows.Forms.Label();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Up_bt = new System.Windows.Forms.Button();
            this.Path_tb = new System.Windows.Forms.TextBox();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.File_bt = new System.Windows.Forms.Button();
            this.Folder_bt = new System.Windows.Forms.Button();
            this.DirectoryList = new System.Windows.Forms.ListView();
            this.treeDirectory = new System.Windows.Forms.TreeView();
            this.CreatePanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.SortPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.DownPanel.SuspendLayout();
            this.createBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePanel
            // 
            this.CreatePanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.CreatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreatePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreatePanel.Controls.Add(this.Create_bt);
            this.CreatePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreatePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreatePanel.Location = new System.Drawing.Point(0, 0);
            this.CreatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(157, 95);
            this.CreatePanel.TabIndex = 0;
            // 
            // Create_bt
            // 
            this.Create_bt.BackColor = System.Drawing.Color.NavajoWhite;
            this.Create_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Create_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Create_bt.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.Create_bt.FlatAppearance.BorderSize = 0;
            this.Create_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.Create_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_bt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Create_bt.Location = new System.Drawing.Point(24, 24);
            this.Create_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Create_bt.Name = "Create_bt";
            this.Create_bt.Size = new System.Drawing.Size(100, 42);
            this.Create_bt.TabIndex = 3;
            this.Create_bt.Text = "Create";
            this.Create_bt.UseVisualStyleBackColor = false;
            this.Create_bt.Click += new System.EventHandler(this.Create_bt_Click);
            // 
            // Rename_bt
            // 
            this.Rename_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rename_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rename_bt.FlatAppearance.BorderSize = 0;
            this.Rename_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.Rename_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rename_bt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rename_bt.Location = new System.Drawing.Point(247, 24);
            this.Rename_bt.Name = "Rename_bt";
            this.Rename_bt.Size = new System.Drawing.Size(100, 42);
            this.Rename_bt.TabIndex = 2;
            this.Rename_bt.Text = "Rename";
            this.Rename_bt.UseVisualStyleBackColor = true;
            this.Rename_bt.Click += new System.EventHandler(this.Rename_bt_Click);
            // 
            // Delete_bt
            // 
            this.Delete_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Delete_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Delete_bt.FlatAppearance.BorderSize = 0;
            this.Delete_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.Delete_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_bt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_bt.Location = new System.Drawing.Point(35, 24);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(100, 42);
            this.Delete_bt.TabIndex = 0;
            this.Delete_bt.Text = " Delete";
            this.Delete_bt.UseVisualStyleBackColor = true;
            this.Delete_bt.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UpPanel.Controls.Add(this.SortPanel);
            this.UpPanel.Controls.Add(this.MenuPanel);
            this.UpPanel.Controls.Add(this.CreatePanel);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1246, 95);
            this.UpPanel.TabIndex = 7;
            // 
            // SortPanel
            // 
            this.SortPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.SortPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SortPanel.Controls.Add(this.Name_tb);
            this.SortPanel.Controls.Add(this.treeView1);
            this.SortPanel.Location = new System.Drawing.Point(558, 0);
            this.SortPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(688, 95);
            this.SortPanel.TabIndex = 5;
            // 
            // Name_tb
            // 
            this.Name_tb.Location = new System.Drawing.Point(540, 32);
            this.Name_tb.Name = "Name_tb";
            this.Name_tb.Size = new System.Drawing.Size(125, 27);
            this.Name_tb.TabIndex = 6;
            this.Name_tb.TextChanged += new System.EventHandler(this.Name_tb_TextChanged);
            this.Name_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_tb_KeyDown);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.NavajoWhite;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            treeNode8.Name = "Name";
            treeNode8.Text = "Name";
            treeNode9.Name = "Weight";
            treeNode9.Text = "Weight";
            treeNode10.Name = "Type";
            treeNode10.Text = "Type";
            treeNode11.Name = "Sort by";
            treeNode11.Text = "Sort by";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(147, 91);
            this.treeView1.TabIndex = 5;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuPanel.Controls.Add(this.Duplicate_bt);
            this.MenuPanel.Controls.Add(this.Rename_bt);
            this.MenuPanel.Controls.Add(this.Delete_bt);
            this.MenuPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(157, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(401, 95);
            this.MenuPanel.TabIndex = 4;
            // 
            // Duplicate_bt
            // 
            this.Duplicate_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Duplicate_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Duplicate_bt.FlatAppearance.BorderSize = 0;
            this.Duplicate_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OldLace;
            this.Duplicate_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Duplicate_bt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Duplicate_bt.Location = new System.Drawing.Point(141, 24);
            this.Duplicate_bt.Name = "Duplicate_bt";
            this.Duplicate_bt.Size = new System.Drawing.Size(100, 42);
            this.Duplicate_bt.TabIndex = 3;
            this.Duplicate_bt.Text = "Duplicate";
            this.Duplicate_bt.UseVisualStyleBackColor = true;
            this.Duplicate_bt.Click += new System.EventHandler(this.Duplicate_bt_Click);
            // 
            // Search_ListView
            // 
            this.Search_ListView.HideSelection = false;
            this.Search_ListView.Location = new System.Drawing.Point(1041, 108);
            this.Search_ListView.Name = "Search_ListView";
            this.Search_ListView.Size = new System.Drawing.Size(95, 27);
            this.Search_ListView.TabIndex = 7;
            this.Search_ListView.UseCompatibleStateImageBehavior = false;
            this.Search_ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Search_ListView_MouseDoubleClick);
            // 
            // DownPanel
            // 
            this.DownPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DownPanel.Controls.Add(this.Search_ListView);
            this.DownPanel.Controls.Add(this.search_label);
            this.DownPanel.Controls.Add(this.Search_tb);
            this.DownPanel.Controls.Add(this.Up_bt);
            this.DownPanel.Controls.Add(this.Path_tb);
            this.DownPanel.Controls.Add(this.createBox);
            this.DownPanel.Controls.Add(this.DirectoryList);
            this.DownPanel.Controls.Add(this.treeDirectory);
            this.DownPanel.Location = new System.Drawing.Point(0, 95);
            this.DownPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(1246, 514);
            this.DownPanel.TabIndex = 8;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(1006, 4);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(67, 20);
            this.search_label.TabIndex = 10;
            this.search_label.Text = "Поиск в:";
            // 
            // Search_tb
            // 
            this.Search_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_tb.Location = new System.Drawing.Point(1074, 0);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(169, 27);
            this.Search_tb.TabIndex = 9;
            this.Search_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_tb_MouseClick);
            this.Search_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_tb_KeyDown);
            // 
            // Up_bt
            // 
            this.Up_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Up_bt.Location = new System.Drawing.Point(194, 0);
            this.Up_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Up_bt.Name = "Up_bt";
            this.Up_bt.Size = new System.Drawing.Size(46, 27);
            this.Up_bt.TabIndex = 8;
            this.Up_bt.Text = "Up";
            this.Up_bt.UseVisualStyleBackColor = false;
            this.Up_bt.Click += new System.EventHandler(this.Up_bt_Click);
            // 
            // Path_tb
            // 
            this.Path_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Path_tb.Location = new System.Drawing.Point(240, 0);
            this.Path_tb.Margin = new System.Windows.Forms.Padding(0);
            this.Path_tb.Name = "Path_tb";
            this.Path_tb.Size = new System.Drawing.Size(761, 27);
            this.Path_tb.TabIndex = 7;
            // 
            // createBox
            // 
            this.createBox.BackColor = System.Drawing.SystemColors.Control;
            this.createBox.Controls.Add(this.File_bt);
            this.createBox.Controls.Add(this.Folder_bt);
            this.createBox.Location = new System.Drawing.Point(2, 95);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(155, 60);
            this.createBox.TabIndex = 6;
            this.createBox.TabStop = false;
            this.createBox.Text = "groupBox1";
            this.createBox.Leave += new System.EventHandler(this.createBox_Leave);
            // 
            // File_bt
            // 
            this.File_bt.Location = new System.Drawing.Point(0, 30);
            this.File_bt.Name = "File_bt";
            this.File_bt.Size = new System.Drawing.Size(155, 30);
            this.File_bt.TabIndex = 1;
            this.File_bt.Text = "File";
            this.File_bt.UseVisualStyleBackColor = true;
            this.File_bt.Click += new System.EventHandler(this.File_bt_Click);
            // 
            // Folder_bt
            // 
            this.Folder_bt.Location = new System.Drawing.Point(0, 0);
            this.Folder_bt.Name = "Folder_bt";
            this.Folder_bt.Size = new System.Drawing.Size(155, 30);
            this.Folder_bt.TabIndex = 0;
            this.Folder_bt.Text = "Folder";
            this.Folder_bt.UseVisualStyleBackColor = true;
            this.Folder_bt.Click += new System.EventHandler(this.Folder_bt_Click);
            // 
            // DirectoryList
            // 
            this.DirectoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryList.HideSelection = false;
            this.DirectoryList.Location = new System.Drawing.Point(194, 27);
            this.DirectoryList.Margin = new System.Windows.Forms.Padding(0);
            this.DirectoryList.Name = "DirectoryList";
            this.DirectoryList.Size = new System.Drawing.Size(1052, 487);
            this.DirectoryList.TabIndex = 1;
            this.DirectoryList.UseCompatibleStateImageBehavior = false;
            this.DirectoryList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DirectoryList_MouseDoubleClick);
            // 
            // treeDirectory
            // 
            this.treeDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDirectory.Location = new System.Drawing.Point(0, 0);
            this.treeDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.treeDirectory.Name = "treeDirectory";
            treeNode12.Name = "File1";
            treeNode12.Text = "File1";
            treeNode13.Name = "File2";
            treeNode13.Text = "File2";
            treeNode14.Name = "Folder";
            treeNode14.Text = "Folder";
            this.treeDirectory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeDirectory.Size = new System.Drawing.Size(195, 514);
            this.treeDirectory.TabIndex = 0;
            this.treeDirectory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeDirectory_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1246, 609);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.UpPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CreatePanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.SortPanel.ResumeLayout(false);
            this.SortPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.DownPanel.ResumeLayout(false);
            this.DownPanel.PerformLayout();
            this.createBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Button Delete_bt;
        private System.Windows.Forms.Button Create_bt;
        private System.Windows.Forms.Button Rename_bt;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Duplicate_bt;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel SortPanel;
        private System.Windows.Forms.Panel DownPanel;
        private System.Windows.Forms.ListView DirectoryList;
        private System.Windows.Forms.TreeView treeDirectory;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.Button File_bt;
        private System.Windows.Forms.Button Folder_bt;
        private System.Windows.Forms.TextBox Path_tb;
        private System.Windows.Forms.Button Up_bt;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.ListView Search_ListView;
    }
}

