using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            user[0] = "admin";
            user[1] = "admin";
            usuarios.Add(user);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        List<string[]> usuarios = new List<string[]>();
        string[] user = new string[2];

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usuarios.Count; i++)
            {
                string[] arr = usuarios[i];
                if (arr[0] == txtUser.Text && arr[1] == txtPassword.Text)
                {
                    Form main = new Main();
                    this.Hide();
                    main.ShowDialog();
                }
                else { MessageBox.Show("Datos incorrectos"); }
            }

        }
    }
}
