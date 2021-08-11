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
    public partial class FormAboutUs : Form
    {
        private string TienTask = "Leader + Design DB";
        private string CamVanTask = "Design DB";
        private string DanhTask = "Implement winform app";
        private string VanTask = "Design DB";
        private string ThienTask = "Implement winform app";
        private string LamTask = "Design DB";
        public FormAboutUs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAboutUs_Load(object sender, EventArgs e)
        {
            txtMem1Task.Text = TienTask;
            txtMem2Task.Text = CamVanTask;
            txtMem3Task.Text = DanhTask;
            txtMem4Task.Text = VanTask;
            txtMem5Task.Text = ThienTask;
            txtMem6Task.Text = LamTask;
        }
    }
}
