using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

using System.Windows.Forms;

namespace monday
{
    //get your computername and ip address
    public partial class system : Form
    {
        public system()
        {
            InitializeComponent();
        }

        private void system_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comname = System.Windows.Forms.SystemInformation.ComputerName;
            string username = System.Windows.Forms.SystemInformation.UserName;
            textBox1.Text=comname;
            textBox2.Text = username;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //get your computername and ip address
            IPAddress[] localIP= Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            { textBox3.Text = address.ToString(); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
