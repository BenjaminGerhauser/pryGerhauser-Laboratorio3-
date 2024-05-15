using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsBoss
    {
        private clsPj Boss;
        Random r = new Random();
        int contador = 207;

        public clsPj boss(int multiplicador)
        {
            Boss = new clsPj();
            PictureBox pbEnemy = new PictureBox();
            pbEnemy.Size = new Size(100, 100);
            pbEnemy.Image = Image.FromFile($"C:sprite/enemy{r.Next(4, 7)}.gif");
            //pbEnemy.Image = Image.FromFile($"C:sprite/enemy5-unscreen.gif");
            pbEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnemy.BackColor = Color.Transparent;
            Boss.Pb = pbEnemy;
            Boss.HP = 200 * multiplicador;
            Boss.Lifes = 1;
            Boss.Point = 1000 * multiplicador;
            Boss.Damage = 25;
            return Boss;
        }
        public void moveBoss(List<clsPj> boss, Form f)
        {
            foreach (clsPj Boss in boss)
            {
                if (Boss.Pb.Location.X <= f.Width - Boss.Pb.Size.Width - 7 /*&& contador > f.Width/2*/)
                {
                    Boss.Pb.Location = new Point(Boss.Pb.Location.X + 5, Boss.Pb.Location.Y);
                    //contador += 5;
                    //if (contador -6 == f.Width - Boss.Pb.Size.Width - 7) contador = f.Width/2;
                }
                else if (Boss.Pb.Location.X > 7 /*&& contador<=f.Width/2*/)
                {
                    Boss.Pb.Location = new Point(Boss.Pb.Location.X - 5, Boss.Pb.Location.Y);
                    //contador -= 5; 
                    //if (contador == 7) contador = f.Width/2 +1;

                }
            }
        }
        public void spawnBoss(List<clsPj> enemies, Form f)
        {
            foreach (clsPj enemy in enemies)
            {
                enemy.Pb.Location = new Point(f.Width/2, r.Next(f.Height / 10, (f.Height / 10) * 3));
                f.Controls.Add(enemy.Pb);
            }
        }
    }
}
