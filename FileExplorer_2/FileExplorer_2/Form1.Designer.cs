namespace FileExplorer_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.home_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.go_button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(212, 198);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(230, 52);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(405, 386);
            this.treeView2.TabIndex = 1;
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 256);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 182);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(467, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(12, 23);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(54, 23);
            this.home_button.TabIndex = 4;
            this.home_button.Text = "HOME";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(72, 23);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(54, 23);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // go_button
            // 
            this.go_button.Location = new System.Drawing.Point(605, 23);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(30, 23);
            this.go_button.TabIndex = 4;
            this.go_button.Text = ">>";
            this.go_button.UseVisualStyleBackColor = true;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_HP-HDD-Dock-512_17248.png");
            this.imageList1.Images.SetKeyName(1, "if_folder-close_173016.png");
            this.imageList1.Images.SetKeyName(2, "if_file_173011.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.go_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.ImageList imageList1;
    }
}

