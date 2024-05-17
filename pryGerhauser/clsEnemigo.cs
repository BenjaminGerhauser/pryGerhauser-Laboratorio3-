using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser
{
    internal class clsEnemigo
    {
		private clsPj objPj;
		private clsPj Boss;
        int contador = 0;
        int contadorY = 1;
        int contadorX = 0;
        Random r = new Random();
		public List<clsPj> bullets = new List<clsPj>();
		//public List<clsPj> enemiesAdd = new List<clsPj>();
		//public List<clsPj> enemiesAddCopy = new List<clsPj>();
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
			foreach (clsPj enemy in enemies)
			{
				if (!f.Contains(enemy.Pb))
				{
					enemy.Pb.Location = new Point(f.ClientSize.Width / 36 + (enemy.Pb.Size.Width * 2) * contadorX, r.Next(55 * contadorY, (55*contadorY)+enemy.Pb.Height));
					f.Controls.Add(enemy.Pb);
					contadorX++;
					if (contadorX == 6) contadorX = 0;
				}
				else
				{
					enemy.Pb.Location = enemy.Pb.Location;

                }
			}
			contadorY++;
			if (contadorY == 4) contadorY = 1;
		}

        public void shootEnemy(List<clsPj> enemies, Form f)
		{
			foreach (clsPj enemy in enemies)
			{
				if (r.Next(1,400) == 3)
				{
					Size size = new Size(8, 14);
                    bullets.Add(bullet.Create(@"../../../sprite/shootEnemy.png", size));
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
		//private void positionControls(List<clsPj> enemies, Form f)
		//{
		//	foreach (clsPj enemy in enemies)
		//	{
		//		int x, y;
		//		x = r.Next(f.Width / 24 + (enemy.Pb.Size.Width * 2) * contador, f.Width / 16 + (enemy.Pb.Size.Width * 2) * contador);
		//		y = r.Next(f.Height / 10, (f.Height / 10) * 3);

		//		while (IsColliding(enemy, x, y, enemiesAdd)) ;

		//		enemy.Pb.Location = new Point(x, y);
		//		contador++;
		//		enemiesAdd.Add(enemy);
		//	}
		//}
		//private bool IsColliding(clsPj enemy, int x, int y, List<clsPj> enemies)
		//{
		//	foreach (clsPj enemy2 in enemies)
		//	{
		//		if (enemy == enemy2) continue;

		//		Rectangle controlRect = new Rectangle(x, y, enemy.Pb.Size.Width, enemy.Pb.Size.Height);
		//		Rectangle otherRect = new Rectangle(enemy2.Pb.Location, enemy2.Pb.Size);

		//		if (controlRect.IntersectsWith(otherRect))
		//		{
		//			return true;
		//		}
		//	}

		//	return false;
		//}
	}
}
