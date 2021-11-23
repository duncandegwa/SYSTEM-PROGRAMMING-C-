using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace monday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void startAProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open tyu = new open(); 
            tyu.MdiParent = this;
            tyu.Show();
        }

        private void displayRunningProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proces kl = new proces();
            kl.MdiParent = this;
            kl.Show();
        }

        private void killProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proces kl = new proces();
            kl.MdiParent = this;
            kl.Show();
        }

        private void openAFilefolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proc ty = new proc();
            ty.MdiParent = this;
            ty.Show();
        }

        private void deleteAFilefolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete hj = new delete();
            hj.MdiParent = this;
            hj.Show();
        }

        private void createFiledirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create nm = new create();
            nm.MdiParent = this;
            nm.Show();
        }

        private void driveInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drive kj = new drive();
            kj.MdiParent = this;
            kj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void startApsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boot mn = new boot();
            mn.MdiParent = this;
            mn.Show();
        }

        private void communicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void processManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void systemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            system jk = new system();
            jk.MdiParent = this;
            jk.Show();
        }

        private void sockets1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socket gf = new socket();
            gf.MdiParent = this;
            gf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void socketsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void socketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            internet kl = new internet();
            kl.MdiParent = this;
            kl.Show();
        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usb nm = new usb(); nm.MdiParent = this;
            nm.Show();
        }

     
    }
}
