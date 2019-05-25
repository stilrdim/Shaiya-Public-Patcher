using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patcher_Public
{
    public partial class successfulPatch : Form
    {
        public successfulPatch()
        {
            InitializeComponent();
        }

        private void successfulPatch_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void successfulPatch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
