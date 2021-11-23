using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace monday
{//POWER OPTIONS
    public partial class boot : Form
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        public boot()
        {
            InitializeComponent();
        }
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(GraphicsUnit uFlags, uint DwReason);
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void boot_Load(object sender, EventArgs e)
        {

        }
        //POWER OPTIONS
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe","-s -t 00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 00");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExitWindowsEx(0,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }
    }
}
