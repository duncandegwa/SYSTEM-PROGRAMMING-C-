using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace monday
{
    public partial class open : Form
    {
        public open()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
            //THIS IS FOR OPENING PROCESSES
            //LIBRARY-using system.Diagnistics
        {
            Process.Start("WinWord");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Excel");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("WordPad");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("vlc.exe");

        }

        private void open_Load(object sender, EventArgs e)
        {

        }
    }
}
