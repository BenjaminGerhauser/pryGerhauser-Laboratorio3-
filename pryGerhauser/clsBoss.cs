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
		clsBullet bullet = new clsBullet();
        public List<clsPj> bullets = new List<clsPj>();
        int contador,first;
        int move = 1;
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
            foreach (clsPj enemy in boss)
            {
                if (enemy.Pb.Location.X == f.Size.Width - enemy.Pb.Size.Width -30) move = -1;
                else if (enemy.Pb.Location.X == 10) move = 1;
                enemy.Pb.Location = new Point(enemy.Pb.Location.X + move, enemy.Pb.Location.Y);
            }
        }
        public void spawnBoss(List<clsPj> Boss, Form f)
        {
            foreach (clsPj enemy in Boss)
            {
                enemy.Pb.Location = new Point(f.Width/2, r.Next(f.Height / 10, (f.Height / 10) * 3));
                f.Controls.Add(enemy.Pb);
            }
        }
        public void shootBoss(List<clsPj> Boss, Form f,int multiplicador)
        {
            foreach (clsPj enemy in Boss)
            {
                if (multiplicador > 400) multiplicador = 400;
                if (r.Next(1, 400/multiplicador) == 1)
                {
                    if (r.Next(1, 300) == 1)
                    {
                        Size size = new Size(8, 150);
                        bullets.Add(bullet.Create($"sprite/laser.png", size));
                    }
                    else {
                        Size size = new Size(8, 14);
                        bullets.Add(bullet.Create($"sprite/shootEnemy.png",size)); 
                    }
                }
                bullet.move(bullets, f, enemy, -10);
            }
        }
    }
}
