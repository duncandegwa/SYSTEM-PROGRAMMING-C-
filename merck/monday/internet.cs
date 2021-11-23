using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace monday
{
    public partial class internet : Form
    {
        public internet()
        {
            InitializeComponent();
        }
        //CHECKING AVAILABLE NETWORKS
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Desc;
            MessageBox.Show(InternetGetConnectedState(out Desc,0).ToString());
        }

        private void internet_Load(object sender, EventArgs e)
        {
            //showconnectionID();
        }
        private void showconnectionID() {
           /* Process P = new Process();
            P.StartInfo.FileName = "netsh.exe";
            P.StartInfo.Arguments = "wlan show interfaces";
            P.StartInfo.UseShellExecute = false;
            P.StartInfo.RedirectStandardOutput = true;
            P.Start();

            string s = P.StandardOutput.ReadToEnd();
            string s1 = s.Substring(s.IndexOf("SSID"));
            s1 = s1.Substring(s1.IndexOf("I"));
            s1 = s1.Substring(2, s1.IndexOf("\n")).Trim();

            string s2 = P.StandardOutput.ReadToEnd();
            //string s2 = s.Substring(s.IndexOf("signal strength"));
            s2 = s2.Substring(s1.IndexOf("I"));
            s2 = s2.Substring(2, s1.IndexOf("\n")).Trim();
            label2.Text = s1;
            label4.Text = s2;
            P.WaitForExit();*/


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //showconnectionID();
        }
    }
}
