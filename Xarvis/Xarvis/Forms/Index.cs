using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Xarvis.Forms;

namespace Xarvis
{
    public partial class Index : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string files, paths;
        int click = 0;
        int voice = 0;
        public Index()
        {
            InitializeComponent();
           
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            if (paths == null)
            {
                MessageBox.Show("Please choose music", "Empty",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (click == 0)
                {
                    player.controls.play();
                    click++;
                }
                else
                {
                    player.controls.pause();
                    click = 0;
                }
            }
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            Voice_System voice_System = new Voice_System();
            voice_System.Show();
            
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            Applist applist = new Applist();
            applist.Show();
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnManualSetting_Click(object sender, EventArgs e)
        {
            Manual manual = new Manual();
            manual.Show();
        }

        private void btnComputerInformation_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("ms-settings:about");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                
                files = openFileDialog.SafeFileName;
                paths = openFileDialog.FileName;
                this.btnchoose.Text = "Loaded";
                player.URL = paths;
            }
        }
    }
}
