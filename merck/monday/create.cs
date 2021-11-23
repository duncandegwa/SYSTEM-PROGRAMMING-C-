using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace monday
{
    public partial class create : Form
    {
        //FILE CREATION
        string Foldername = @"D:\meru";
        public create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
            
        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (!File.Exists(path))
            {
                File.Create(@"D:\meru");
                MessageBox.Show("file created successfully...!");
            }
            else {
                MessageBox.Show("file already exists");
            }
        }



        //FILE CREATION
        private void button3_Click(object sender, EventArgs e)
        {
          string path = textBox2.Text;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(@"D:\meru");
                MessageBox.Show("SUCCESSFULLY CREATED...!");
               
            }
            else
            {
                MessageBox.Show("Directory already exists");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //file creation
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);
                foreach (string file in files) { listBox1.Items.Add(Path.GetFileName(file)); }
                foreach (string dir in dirs) { listBox1.Items.Add(Path.GetFileName(dir)); }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void create_Load(object sender, EventArgs e)
        {

        }

        }
    }

