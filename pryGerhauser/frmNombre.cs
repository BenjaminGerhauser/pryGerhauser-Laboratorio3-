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
    public partial class frmNombre : Form
    {
        public frmNombre()
        {
            InitializeComponent();
        }
        private string playerName;
         public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            frmJuego j = new frmJuego();
            j.lblPlayer.Text = txtName.Text;
            this.Hide();
            j.ShowDialog();
        }

       




    }
}
