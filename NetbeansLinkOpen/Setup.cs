using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NetbeansLinkOpen
{
    public partial class Setup : Form
    {

        public Setup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.updateStatus();
        }

        private void updateStatus()
        {

            string netbeansPath = this.textBoxNetbeansPath.Text != "" ? this.textBoxNetbeansPath.Text : NetbeansDetector.detectNetbeansPath();
            this.textBoxNetbeansPath.Text = netbeansPath;

            string currentHandler = NetbeansCallbackInstaller.getCurrentHandler();
            this.labelStatus.Text = currentHandler != null ? "installed" : "not installed";

            if (currentHandler != null
                && currentHandler != NetbeansCallbackInstaller.getValidHandlerValue(netbeansPath))
            {
                this.labelStatus.Text += ", but is different";
            }

            this.buttonInstall.Enabled = true;
        }

        

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            string error = NetbeansCallbackInstaller.installHandler(this.textBoxNetbeansPath.Text);
            this.updateStatus();
            if (error != null)
            {
                labelStatus.Text = error;
            }
        }
    }
}
