﻿// Проект по созданию модели логической файловой системы 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDirectory
{
    public partial class Form1 : Form
    {
        Folder Root;
        Folder ActiveFolder;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide_Drop_List();
            Root = new Folder();
            Folder C = new Folder("C:", Root);
            ActiveFolder = Root;
            MenuPanel.Enabled = false;
            Name_tb.Enabled = false;
            Name_tb.Visible = false;


            treeView1.ExpandAll();


            DirectoryList.View = View.Details;
            DirectoryList.FullRowSelect = true; // Получает или задает значение, указывающее, выбираются ли при щелчке элемента все его подэлементы.
            DirectoryList.MultiSelect = true;

            DirectoryList.Columns.Add("Name", Convert.ToInt32(DirectoryList.Width * 0.3));      //Add column header
            DirectoryList.Columns.Add("Type", Convert.ToInt32(DirectoryList.Width * 0.1));      //Add column header
            DirectoryList.Columns.Add("Weight", Convert.ToInt32(DirectoryList.Width * 0.1));    //Add column header
            
            ImageList imageListSmall = new ImageList();
            imageListSmall.Images.Add(Bitmap.FromFile(@"Pictures\folder2.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(@"Pictures\file2.png"));
            imageListSmall.ImageSize = new Size(32, 32);

            DirectoryList.SmallImageList = imageListSmall;
            UpdateDirectoryList();
        }


        private void Create_bt_Click(object sender, EventArgs e)
        {
            Hide_Drop_List();
            createBox.Location = new Point(2, 0);
            createBox.Visible = true;
            createBox.Enabled = true;
            createBox.Select();

        }
        private void Hide_Drop_List()
        {
            createBox.Enabled = false;
            createBox.Visible = false;
        }
        private void createBox_Leave(object sender, EventArgs e)
        {
            Hide_Drop_List();
        }

        private void Folder_bt_Click(object sender, EventArgs e)
        {
            try
            {
                MyObject newFolder = new Folder("new folder", ActiveFolder);
                UpdateDirectoryList();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            Hide_Drop_List();
        }

        private void UpdateDirectoryList()
        {
            int indexImage;
            if (ActiveFolder != Root)
            {
                MenuPanel.Enabled = true;
            }
            else
            {
                MenuPanel.Enabled = false;
            }
            Path_tb.Text = ActiveFolder._Path;
            DirectoryList.Items.Clear();
            string[] arr = new string[3];
            foreach (MyObject obj in ActiveFolder.Return_Children())
            {
                arr[0] = obj._Name;
                var a = obj.GetType().ToString();
                if (obj.GetType().ToString() == "MyDirectory.Folder")
                {

                    arr[1] = "Folder";
                    arr[2] = "";
                    indexImage = 0;
                }
                else
                {
                    File file = obj as File;
                    arr[1] = "File";
                    arr[2] = file._Weight.ToString();
                    indexImage = 1;
                }
                DirectoryList.Items.Add(arr[0], indexImage);
                DirectoryList.Items[DirectoryList.Items.Count - 1].SubItems.Add(arr[1]);
                DirectoryList.Items[DirectoryList.Items.Count - 1].SubItems.Add(arr[2]);

            }
            TreeUpdate();
        }
        private void TreeUpdate()
        {
            treeDirectory.Nodes.Clear();
            treeDirectory.BeginUpdate();
            TreeNodes(Root, treeDirectory.Nodes);
            treeDirectory.EndUpdate();
        }
        private void TreeNodes(Folder Parent, TreeNodeCollection nodes)
        {
            var Children = Parent.Children;
            for (int i = 0; i < Children.Count; i++)
            {
                int CountNodes = 0;
                if (Children[i].GetType().ToString() == "MyDirectory.Folder")
                {
                    nodes.Add(Children[i]._Name);
                    TreeNodes(Children[i] as Folder, nodes[CountNodes].Nodes);
                    CountNodes++;
                }
            }
        }

        private void DirectoryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = DirectoryList.FocusedItem.Index;
            MyObject child = ActiveFolder.Return_Children()[index];
            if (child.GetType().ToString() == "MyDirectory.Folder")
            {
                ActiveFolder = child as Folder;
                UpdateDirectoryList();
            }
            else
            {
                MessageBox.Show($"The <<{child._Name}>> file has been opened");
            }

        }

        private void Up_bt_Click(object sender, EventArgs e)
        {
            if (ActiveFolder._Parent != null)
            {
                ActiveFolder = ActiveFolder._Parent as Folder;
                UpdateDirectoryList();
            }
        }

        private void File_bt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            try
            {
                MyObject newFile = new File("new file", ActiveFolder, rnd.Next(10, 500));
                UpdateDirectoryList();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            Hide_Drop_List();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (DirectoryList.SelectedItems.Count != 0)
            {
                var a = DirectoryList.SelectedItems;
                for (int i = 0; i < a.Count; i++)
                {
                    ActiveFolder.Delete_Child(a[i].Index - i);
                }
                UpdateDirectoryList();
            }

        }

        private void Duplicate_bt_Click(object sender, EventArgs e)
        {
            if (DirectoryList.SelectedItems.Count != 0)
            {
                var index = DirectoryList.FocusedItem.Index;
                MyObject child = ActiveFolder.Return_Children()[index];
                var name = child._Name + " — Копия " + child.CountIs;
                child.CountIs++;

                //string name  ;

                if (child.GetType().ToString() == "MyDirectory.Folder")
                {
                    Folder select = child as Folder;
                    try
                    {
                        Folder Duplicate = new Folder(name, ActiveFolder);
                        List<MyObject> list = new List<MyObject>();
                        foreach (MyObject obj in select.Return_Children())
                        {
                            list.Add(obj);
                        }
                        Duplicate.Children = list;
                        UpdateDirectoryList();
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
                else
                {
                    File select = child as File;
                    try
                    {
                        MyObject newFile = new File(name, ActiveFolder, select._Weight);
                        UpdateDirectoryList();
                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }
                }
            }

        }

        private void Rename_bt_Click(object sender, EventArgs e)
        {
            if (DirectoryList.SelectedItems.Count != 0)
            {
                Name_tb.Location = DirectoryList.FocusedItem.Position;
                Name_tb.Text = DirectoryList.FocusedItem.Text;
                Name_tb.Width = Name_tb.Text.Length * 8 + 100;
                DirectoryList.Controls.Add(Name_tb);
                Name_tb.Enabled = true;
                Name_tb.Visible = true;
                Name_tb.Focus();
                Name_tb.SelectAll();
            }
        }
        private void Name_tb_TextChanged(object sender, EventArgs e)
        {
            Name_tb.Width = Name_tb.Text.Length * 8 + 100;
        }

        private void Name_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var index = DirectoryList.FocusedItem.Index;
                MyObject child = ActiveFolder.Return_Children()[index];
                try
                {
                    child.ReName(Name_tb.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                Name_tb.Location = new Point(this.Width, 0);
                Name_tb.Enabled = false;
                Name_tb.Visible = false;
                UpdateDirectoryList();
            }
        }

        private void treeDirectory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var a = treeDirectory.SelectedNode;
            if (a != null)
            {
                List<TreeNode> List = new List<TreeNode>();
                while (a.Parent != null)
                {
                    List.Add(a);
                    a = a.Parent;
                }
                Folder myFolder = Root.Children[0] as Folder;
                for (int i = List.Count - 1; i >= 0; i--)
                {
                    myFolder = descent(myFolder, List[i].Text);
                }
                ActiveFolder = myFolder;
                UpdateDirectoryList();
            }
            treeView1.ExpandAll();

        }
        private Folder descent(Folder Parent, string name)
        {
            Folder folder = Parent;
            foreach (MyObject obj in Parent.Children)
            {
                if (obj.GetType().ToString() == "MyDirectory.Folder")
                {
                    Folder current = obj as Folder;
                    if (current._Name == name)
                    {
                        folder = current;
                    }
                }
            }
            return folder;
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {

                int sort = treeView1.SelectedNode.Index;

                if (sort == 0) // name
                {
                    ActiveFolder.SortByName();
                }
                if (sort == 1) // Weight
                {
                    ActiveFolder.SortByWeight();
                }
                if (sort == 2) // Type
                {
                    ActiveFolder.SortByType();
                }
                UpdateDirectoryList();

            }

        }


    }
}
