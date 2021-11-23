using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace monday
{
    //SOCKET IMPLEMENTATION
    public partial class socket : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public socket()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void socket_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);
            textLocalIP.Text = GetLocalIP();
            textRemoteIp.Text = GetLocalIP();
            
        
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host= Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "10.10.152.212";
        }
        //SOCKET IMPLEMENTATION
        private void buttonconect_Click(object sender, EventArgs e)
        {

            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);
            //epremote = new IPEndPoint(IPAddress.Parse(textremoteip.Text ),Convert.ToInt32(textremoteport));
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);
            buffer= new byte[1500];
            sck.BeginReceiveFrom(buffer,0,buffer.Length,SocketFlags.None,ref epRemote,new AsyncCallback(MessageCallBack),buffer);
            if (textRemotePort == textLocalPort)
            {
                MessageBox.Show("  connection failure");
            }
            else { MessageBox.Show("Connection established"); }
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] ReceavedData = new byte[1500];
                ReceavedData = (byte[])aResult.AsyncState;
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string ReceavedMessage = aEncoding.GetString(ReceavedData);

                listmesage.Items.Add("receaver:" + ReceavedMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            //SOCKETS
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textmesage.Text);
            sck.Send(sendingMessage);
            listmesage.Items.Add("sender: " +textmesage.Text);
            listBoxfr.Items.Add("sender: " + textmesage.Text);
            textmesage.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textBox.Text);
            sck.Send(sendingMessage);
            listBoxfr.Items.Add("receaver: " + textBox.Text);
            listmesage.Items.Add("receaver: " + textBox.Text);
            textBox.Text = " ";
        }
    }
    
}
