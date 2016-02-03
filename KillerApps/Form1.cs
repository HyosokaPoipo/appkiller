using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillerApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void killerButton_Click(object sender, EventArgs e)
        {
            string selectedApp = listBoxApps.Text;
            foreach (Process p in Process.GetProcesses())
            {
                if (selectedApp.Contains(p.ProcessName))
                {
                    p.Kill();
                    listBoxApps.Items.Remove(selectedApp);
                    MessageBox.Show(p.ProcessName + "Telah dihentikan...!");
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nampilin daftar aplikasi running di listBox
            foreach (Process p in Process.GetProcesses())
            {
                listBoxApps.Items.Add(p.ProcessName+"===>"+p.MainWindowTitle);
            }
        }
    }
}
