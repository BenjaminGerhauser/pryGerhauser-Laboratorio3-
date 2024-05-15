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

        //public clsPj Pj
        //{
        //	get { return pj; }
        //	set { pj = value; }
        //}
        Random r = new Random();
		public List<clsPj> bullets = new List<clsPj>();
		clsBullet bullet = new clsBullet();
		int contadorMove;
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
				enemy.Pb.Location = new Point(f.Width/ 20 + (enemy.Pb.Size.Width * 2)*contador, r.Next(f.Height / 10, (f.Height / 10)*3));
				f.Controls.Add(enemy.Pb);
				contador++;
			}
		}
		public void shootEnemy(List<clsPj> enemies, Form f)
		{
			foreach (clsPj enemy in enemies)
			{
				if (r.Next(1,300) == 3)
				{
					bullets.Add(bullet.Create($"sprite/shootEnemy.png"));
				}
				bullet.move(bullets,f,enemy,-10);
			}

		}
		public void moveEnemy(List<clsPj> enemies)
		{
			
			if (contadorMove > 0 && contadorMove <6)
			{
				foreach (clsPj enemy in enemies)
				{
					enemy.Pb.Location = new Point(enemy.Pb.Location.X + 1, enemy.Pb.Location.Y);
					enemy.Pb.Refresh();
                contadorMove ++;
				}
            }
            else if(contadorMove <= 0 && contadorMove >-5) 
			{
				foreach (clsPj enemy in enemies)
				{
					enemy.Pb.Location = new Point(enemy.Pb.Location.X - 1, enemy.Pb.Location.Y);
					enemy.Pb.Refresh();
					contadorMove --;
				}
            }

        }
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
		int contador = 0;
		public void moveBoss(List<clsPj> boss,Form f)
		{
			foreach (clsPj Boss in boss)
			{
				if (Boss.Pb.Location.X < f.Width - Boss.Pb.Size.Width && contador < 100)
				{
					Boss.Pb.Location = new Point(Boss.Pb.Location.X + 5, Boss.Pb.Location.Y);
					contador += 5;
                }
				else if (Boss.Pb.Location.X > 5 && contador >= 100)
				{
                    Boss.Pb.Location = new Point(Boss.Pb.Location.X - 5, Boss.Pb.Location.Y);
                }
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
