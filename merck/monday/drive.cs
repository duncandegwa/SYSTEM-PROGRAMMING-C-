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
    public partial class drive : Form
    {
        public drive()
        {
            InitializeComponent();
            getdrive();
        }

        private void getdrive()
        {
           
            {}
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {//DRIVE INFO
            MessageBox.Show("HERE IS A YOUR COMPUTER HARDWARE INFORMATION");
            int NoOfDisk = 0;
            foreach (DriveInfo drinfo in DriveInfo.GetDrives())
            {
                MessageBox.Show("DriveName" + drinfo.Name+"\n"
            + "DriveLabel :" + drinfo.VolumeLabel + "\n"
            + "Total Space:" + drinfo.TotalSize / 1073741824 + " GB\n"
            + "Total Free Space:" + drinfo.TotalFreeSpace / 1073741824 + " GB\n"
             + "DriveType :" + drinfo.DriveType
                    );
            }
            MessageBox.Show("Total Disk:" + (NoOfDisk-1).ToString());

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

    }
}
