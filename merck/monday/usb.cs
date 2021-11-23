using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
namespace monday
{
    public partial class usb : Form
    {
        //INPUT OUTPUT DEVICES
        private const int WM_DEVICECAHENGE = 0X219;
        private const int DBT_DEVICEARRIVAL = 0X8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0X8004;
        private const int DBT_DEVICETYP_VOLUME = 0X00000002;

        protected override void WndProc(ref Message m)
        {
            //INPUT OUTPUT DEVICES
            base.WndProc(ref m);
            switch(m.Msg)
            {
                case WM_DEVICECAHENGE: { 
                    switch((int)m.WParam)
                    {
                        case DBT_DEVICEARRIVAL:
                            findings.Items.Add("NEW DEVICE CONNECTED >!!");
                            break;

                        case DBT_DEVICEREMOVECOMPLETE:
                            findings.Items.Add(" DEVICE REMOVED^!!");
                            break;

                    } break;
                }

            }
        }

        //INPUT OUTPUT
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
        protected static extern int mciSendString(string lpstrCommand, StringBuilder lsprReturnString, int uReturnLength, IntPtr hwndcallback);
        public usb()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text = "DVD Opening..";
            ProcessCdtray(true);
            label15.Text = "DVD has opened!";

        }
        public bool ProcessCdtray(bool open)
        {//INPUT OUTPUT
            int ret = 0;
            switch (open)
            { 
                case true:
                     ret= mciSendString("set cdaudio door open", null,0,IntPtr.Zero);
                    return  true;
                    break;

                case false:
                    ret= mciSendString("set cdaudio door closed", null,0,IntPtr.Zero);
                     return  true;
                    break;
                default:
                    ret= mciSendString("set cdaudio door open", null,0,IntPtr.Zero);
                    return  true;
                    break;
            }
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            //INPUT OUTPUT
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                label13.Text = drives.FirstOrDefault().DriveFormat.ToString();
                label12.Text = drives.FirstOrDefault().DriveType.ToString();
                label11.Text = drives.FirstOrDefault().TotalFreeSpace.ToString();
                label10.Text = drives.FirstOrDefault().IsReady.ToString();
                label9.Text = drives.FirstOrDefault().Name.ToString();
                label8.Text = drives.FirstOrDefault().TotalSize.ToString();
            }
            else { MessageBox.Show("No pendrive connected"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label15.Text = "DVD Closing..";
            ProcessCdtray(false);
            label15.Text = "DVD has Closed!";
        }

        private void usb_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            findings.Items.Clear();
        }
    

    }
}
