using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsEnemigo
    {
		private clsPj objPj;
		private clsPj Boss;
        int contador = 0;
        Random r = new Random();
		public List<clsPj> bullets = new List<clsPj>();
        clsBullet bullet = new clsBullet();
		

        public clsPj Create()
		{
			objPj = new clsPj();
			PictureBox pbEnemy = new PictureBox();
            pbEnemy.Size = new Size(35, 35);
			pbEnemy.Image = Image.FromFile($"C:sprite/enemy{r.Next(4, 7)}.gif");
			//pbEnemy.Image = Image.FromFile($"C:sprite/enemy5-unscreen.gif");
			pbEnemy.SizeMode = PictureBoxSizeMode.Zoom;
			pbEnemy.BackColor = Color.Transparent;
			objPj.Pb = pbEnemy;
            objPj.HP = r.Next(1,51);
            objPj.Lifes = 1;
            objPj.Point = r.Next(10,20);
            objPj.Damage = 25;
			return objPj;
		}
		public void spawn(List<clsPj> enemies, Form f)
		{
            for (int i = 0; i < 6; i++)
            {
                clsPj nuevo;
                nuevo = Create();
                enemies.Add(nuevo);
            }

			int contador = 0;
			foreach (clsPj enemy in enemies)
			{
				foreach (clsPj enemy2 in enemies)
				{
					if (enemy.Pb.Bounds.IntersectsWith(enemy2.Pb.Bounds) && enemy != enemy2 && !f.Contains(enemy.Pb) && !f.Contains(enemy2.Pb))
					{
						enemy.Pb.Location = new Point(f.Width / 36 + (enemy.Pb.Size.Width * 2) * contador + enemy.Pb.Size.Width, r.Next(f.Height / 10, (f.Height / 10) * 3));
						f.Controls.Add(enemy.Pb);
					}
					else if (!f.Contains(enemy.Pb) && !f.Contains(enemy2.Pb))
					{
						enemy.Pb.Location = new Point(f.Width / 36 + (enemy.Pb.Size.Width * 2) * contador, r.Next(f.Height / 10, (f.Height / 10) * 3));
						f.Controls.Add(enemy.Pb);
					}
				}
				contador++;
			}
		}
		public void shootEnemy(List<clsPj> enemies, Form f)
		{
			foreach (clsPj enemy in enemies)
			{
				if (r.Next(1,300) == 3)
				{
					Size size = new Size(8, 14);
                    bullets.Add(bullet.Create($"sprite/shootEnemy.png",size));
				}
				bullet.move(bullets,f,enemy,-8);
			}
		}
		public void moveEnemy(List<clsPj> enemies)
		{
			if(contador <8 && contador >=0)
			{
				foreach (clsPj enemy in enemies)
				{
					enemy.Pb.Location = new Point(enemy.Pb.Location.X + 1, enemy.Pb.Location.Y);
				}
				contador++;
				if (contador == 8) contador = -1;
			}
			else if(contador <0 && contador >= -8)
			{
                foreach (clsPj enemy in enemies)
                {
                    enemy.Pb.Location = new Point(enemy.Pb.Location.X - 1, enemy.Pb.Location.Y);
                }
                contador--;
                if (contador == -9) contador= 0;
            }
        }
		public void deleteEnemies(List<clsPj> enemies,Form f)
		{
            List<clsPj> copyEnemies = new List<clsPj>(enemies);
            foreach (clsPj enemy in copyEnemies)
			{
				enemy.Pb.Dispose();
				enemies.Remove(enemy);
			}
		}
	}
}
