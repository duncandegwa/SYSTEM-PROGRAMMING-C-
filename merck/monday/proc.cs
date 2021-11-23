using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace monday
{
    public partial class proc : Form
    {
        DirectoryInfo di;
        public proc()
        {
            InitializeComponent();
        }
        //THIS IS FOR PROCESS MANAGEMENT

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string Filename = openFileDialog.FileName;
                System.Diagnostics.Process.Start(Filename);
            }
        }

        //THIS IS FOR PROCESS MANAGEMENT
        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                di= new DirectoryInfo (textBox1.Text);
                di.Attributes = FileAttributes.Hidden;
                MessageBox.Show("FILE IS HIDDEN");
            }
            catch(Exception ex){
                MessageBox.Show("message occorrred due to " +ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //FILE MANAGEMENT
            try
            {
                di = new DirectoryInfo(textBox1.Text);
                di.Attributes = FileAttributes.Normal;
                MessageBox.Show("FILE IS BACK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("message occorrred due to " + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
