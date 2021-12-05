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

namespace Xarvis.Forms
{
    public partial class Applist : Form
    {

        public Applist()
        {
            InitializeComponent();
         
            List<string> x = new List<string> { };
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {

                        if (subkey.GetValue("DisplayName") != null)
                        {

                            x.Add(subkey.GetValue("DisplayName").ToString());
                            //i++;

                        }
                        var name = subkey.GetValue("DisplayName");
                        Console.WriteLine(subkey.GetValue("DisplayName"));
                        Console.ReadLine();

                    }
                    //if (i == 100) break;
                    //System.Diagnostics.Process.Start("explorer.exe", @" shell:appsFolder\" + appModelUserID);
                }

            }
            for(int i=0;i<x.Count;i++)
            {
                // tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Label l = new Label();
                l.Text = x.ElementAt(i);
                l.AutoSize = true;
                tableLayoutPanel1.Controls.Add(new Label() { Text = i.ToString() }, 0, i);
                tableLayoutPanel1.Controls.Add(l, 1, i) ;
            }
            Console.WriteLine(x.Count);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.AutoScroll = true;
            
        }

        private void tblApp_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Applist_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
