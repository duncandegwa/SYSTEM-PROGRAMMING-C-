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
    public partial class proces : Form
    {
        //THIS IS FOR DISPLAYING ALL RUNNIG PROCESSES AND TERMINATING THEM
        private Process[] _processes =Process.GetProcesses();
        public proces()
        {
            InitializeComponent();
          PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            cmbProcesses.Items.Clear();
            foreach (Process process in _processes)
            {
                cmbProcesses.Items.Add(process.ProcessName);


            }
        }

        private void cnbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProcesses.SelectedIndex != -1)
            {
                int index = cmbProcesses.SelectedIndex;
                propertyGrid1.SelectedObject = _processes[index];
                propertyGrid2.SelectedObject = _processes[index].StartInfo;
            }
        }
        //THIS IS FOR DISPLAYING ALL RUNNIG PROCESSES AND TERMINATING THEM
        private void button1_Click(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbProcesses.SelectedIndex != -1)
            {
                try
                {
                    _processes[cmbProcesses.SelectedIndex].Kill();
                }
                catch {
                    MessageBox.Show("Successfully Terminated...");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid2_Click(object sender, EventArgs e)
        {

        }
    }
}
