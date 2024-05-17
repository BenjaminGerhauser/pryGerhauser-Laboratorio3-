using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pryGerhauser
{
    public partial class frmFirma : Form
    {
        Bitmap bm;
        Graphics g;
        Pen lapiz = new Pen(Color.Black, 5);
        Point px, py;
        bool click = false;
        public frmFirma()
        {
            InitializeComponent();
            bm = new Bitmap(picFirma.Width, picFirma.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            picFirma.Image = bm;
        }

        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picFirma.Image = bm;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rutaProyecto = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            string fecha = System.DateTime.Now.ToString("yyyy-MM-d-H.m.s");
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            sfd.FileName =  fecha.ToString();
            sfd.InitialDirectory = rutaProyecto;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, picFirma.Width, picFirma.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Imagen guardada");
            }
        }

        private void picFirma_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;

        }

        private void picFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                px = e.Location;
                g.DrawLine(lapiz, px, py);
                py = px;
            }
            picFirma.Refresh();
        }

        private void picFirma_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            py = e.Location;
        }
    }
}
