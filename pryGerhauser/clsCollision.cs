using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser
{
    internal class clsCollision
    {
        //List<clsPj> copyNaves = new List<clsPj>(naves);
        clsNave claseNave = new clsNave();
        clsLevel clsLevel = new clsLevel();
        public void checkCollitionEnemy(List<clsPj> bullets, List<clsPj> enemies,Label lblPoints,int pointsLevel,ProgressBar bar)
        {
            int points = Convert.ToInt32(lblPoints.Text);

            List<clsPj> copyEnemies = new List<clsPj>(enemies);
            List<clsPj> copyBullets = new List<clsPj>(bullets);
            foreach (clsPj bullet in copyBullets)
            {
                foreach (clsPj enemy in copyEnemies)
                {
                    if (bullet.Pb.Bounds.IntersectsWith(enemy.Pb.Bounds))
                    {
                        if(enemy.HP <= 25)
                        {
                            enemy.Pb.Dispose();
                            bullet.Pb.Dispose();
                            bullets.Remove(bullet);
                            enemies.Remove(enemy);
                            points += enemy.Point;
                            lblPoints.Text = points.ToString();
                            clsLevel.levelPoints(bar, enemy.Point);
                        }
                        else if (enemy.HP > 25)
                        {
                            bullet.Pb.Dispose();
                            bullets.Remove(bullet);
                            enemy.HP -= bullet.Damage;
                        }
                    }
                }
            }
        }
        public void checkCollitionNave(List<clsPj> bullets, List<clsPj> naves, Label lblPoints,Form f,List<PictureBox> vidas)
        {
            int points = Convert.ToInt32(lblPoints.Text);
            List<clsPj> copyNaves = new List<clsPj>(naves);
            List<clsPj> copyBullets = new List<clsPj>(bullets);
            List<PictureBox> vidasNave = new List<PictureBox>(vidas);
            foreach (clsPj bullet in copyBullets)
            {
                foreach (clsPj nave in copyNaves)
                {
                    if (bullet.Pb.Bounds.IntersectsWith(nave.Pb.Bounds))
                    {
                        //nave.Pb.Dispose();
                        
                        nave.Lifes--;
                        bullet.Pb.Dispose();
                        bullets.Remove(bullet);
                        //naves.Remove(nave);
                        //points += nave.Point;
                        //lblPoints.Text = points.ToString();
                        claseNave.spawn(nave,f);
                        int lifes = nave.Lifes;
                        foreach (PictureBox pb in vidas)
                        {
                            if (f.Controls.Contains(pb) && pb.Name == $"vida{nave.Lifes - 1}") pb.Dispose();
                        }
                        if(nave.Lifes == 0)
                        {
                            f.Close();
                            frmFinJuego fin = new frmFinJuego();
                            fin.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
