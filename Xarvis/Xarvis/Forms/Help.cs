using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xarvis
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.pnlHelp.BackColor = Color.FromArgb(100, Color.White);
        }

        private void pnlHelp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
