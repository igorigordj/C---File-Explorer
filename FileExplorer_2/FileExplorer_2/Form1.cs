using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileExplorer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            //Clears the content of a treeView1
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();


            //Loads all logical drives into treeView
            string[] driverID = Directory.GetLogicalDrives();
            foreach(string drive in driverID)
            {
                TreeNode mainNode = new TreeNode();
                mainNode.ImageIndex = 0;
                mainNode.SelectedImageIndex = 0;
                treeView1.Nodes.Add(drive);

            }
        }

        private void ShowDriveDirectories()
        {
            try
            {
                //Clears the content of a treeView2
                treeView2.Nodes.Clear();

                //Loads directories and files
                string[] directories = Directory.GetDirectories(treeView1.SelectedNode.Text);
                string[] files = Directory.GetFiles(treeView1.SelectedNode.Text);

                //Adds directories to treeView2
                foreach (string dir in directories)
                {
                    treeView2.Nodes.Add(dir);
                    treeView1.SelectedNode.Nodes.Add(dir);
                }

                //Adds directory path to comboBox at the top
                comboBox1.Text = treeView1.SelectedNode.Text;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void GoToDirectory()
        {
            try
            {
                //Clears the content of a treeView2
                treeView2.Nodes.Clear();

                //Loads directories and files
                string[] directories = Directory.GetDirectories(treeView1.SelectedNode.Text);
                string[] files = Directory.GetFiles(treeView1.SelectedNode.Text);

                //Adds directories to treeView2
                foreach (string dir in directories)
                {
                    treeView2.Nodes.Add(dir);
                    
                }

               if(comboBox1.Items.Contains(comboBox1.Text)== false)
               {
                    comboBox1.Items.Add(comboBox1.Text);
               }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            

            string direct = treeView2.SelectedNode.Text;

            try
            {
                treeView2.Nodes.Clear();

                string[] directories = Directory.GetDirectories(treeView2.SelectedNode.Text);
                string[] files = Directory.GetFiles(treeView2.SelectedNode.Text);

                //Adds directories to treeView2
                foreach (string dir in directories)
                {
                    treeView2.Nodes.Add(dir);
                }
                comboBox1.Text = direct;
                if (comboBox1.Items.Contains(comboBox1.Text) == false)
                {
                    comboBox1.Items.Add(direct);
                }

            }
            catch (Exception)
            {
                try
                {
                    comboBox1.Text = direct;
                    System.Diagnostics.Process.Start(direct);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


        }

        // when comboBox1 keyDown or enter is pressed
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                GoToDirectory();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowDriveDirectories();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();

            string[] driverID = Directory.GetLogicalDrives();
            foreach (string drive in driverID)
            {
                treeView1.Nodes.Add(drive);
            }
            comboBox1.Text = "Home";
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            try
            {
                string[] directories = Directory.GetDirectories(treeView1.SelectedNode.Text);
                string[] files = Directory.GetFiles(treeView1.SelectedNode.Text);

                //Adds directories to treeView2
                foreach (string dir in directories)
                {
                    treeView2.Nodes.Add(dir);
                }
               
                if (comboBox1.Items.Contains(comboBox1.Text) == false)
                {
                    comboBox1.Items.Add(comboBox1.Text);
                }

            }
           
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

           
        }
    }
}
