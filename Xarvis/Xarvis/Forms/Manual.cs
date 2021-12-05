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

namespace Xarvis
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("control", "appwiz.cpl");//Individual control panel
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGotoPanel_Click(object sender, EventArgs e)
        {
            Process.Start("control");//Only for control panel
           // System.Diagnostics.Process.Start("control", "powercfg.cpl");//Individual control panel
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            try
            {
               Process.Start("control", "mmsys.cpl");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWifi_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:network-wifi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:wifi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:about");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBluetooth_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:bluetooth");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "shell:RecycleBinFolder");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("perfmon");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
