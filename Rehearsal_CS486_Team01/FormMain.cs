using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehearsal_CS486_Team01
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutUs aboutUs = new FormAboutUs();
            aboutUs.ShowDialog()
;        }
    }
}
