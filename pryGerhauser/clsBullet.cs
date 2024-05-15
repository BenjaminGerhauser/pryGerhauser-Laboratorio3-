using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsBullet
    {
        clsPj objPj;
        public clsPj Create(string bala)
        {
            objPj = new clsPj();
            PictureBox pbEnemy = new PictureBox();
            pbEnemy.Size = new Size(8, 14);
            pbEnemy.Image = Image.FromFile(bala);
            pbEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnemy.BackColor = Color.Transparent;
            objPj.Pb = pbEnemy;
            objPj.HP = 0;
            objPj.Lifes = 0;
            objPj.Point = 0;
            objPj.Damage = 25;
            return objPj;
        }
        public void move(List<clsPj> bullets,Form f,clsPj nave,int direccion)
        {
            foreach (clsPj bullet in bullets)
            {
                if (!f.Controls.Contains(bullet.Pb)) { bullet.Pb.Location = new Point(nave.Pb.Location.X + (nave.Pb.Size.Width/2), nave.Pb.Location.Y);f.Controls.Add(bullet.Pb); }
                bullet.Pb.Location = new Point(bullet.Pb.Location.X, bullet.Pb.Location.Y - direccion);
                f.Controls.Add(bullet.Pb);
                bullet.Pb.Refresh();
            }
        }
    }
}
