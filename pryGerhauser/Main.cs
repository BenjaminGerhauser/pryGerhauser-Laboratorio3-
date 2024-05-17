using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void galagaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNombre nombre = new frmNombre();
            nombre.Show();
        }
    }
}
