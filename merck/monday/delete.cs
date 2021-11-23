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
    public partial class delete : Form
    {
        //FILE CREATION AND DELETION
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FILE CREATION AND DELETION
            string filepath = textBox1.Text;
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                MessageBox.Show("successfull deletion");
            }
            else { MessageBox.Show("file does not exist"); }

        }

   
      

        private void button3_Click_1(object sender, EventArgs e)
        {
            string folderpath = textBox2.Text;
            if (File.Exists(folderpath))
            {
                File.Delete(folderpath);
                MessageBox.Show("successfull deletion");
            }
            else { MessageBox.Show("folder does not exist"); }
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }
    }
}
