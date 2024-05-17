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
        clsScores clsScores = new clsScores();
        int globalPoints = 0;
        public int checkCollitionEnemy(List<clsPj> bullets, List<clsPj> enemies,Label lblPoints,ProgressBar bar,Label lblLevel,Form f,int POINTS)
        {
            int points = POINTS;
            globalPoints = POINTS;
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
                            //clsLevel.levelPoints(bar, enemy.Point,lblLevel);
                            return enemy.Point;
                        }
                        else if (enemy.HP > 25)
                        {
                            bullet.Pb.Dispose();
                            bullets.Remove(bullet);
                            enemy.HP -= bullet.Damage;
                        }
                    }
                    else if(bullet.Pb.Location.Y >= f.Size.Height + bullet.Pb.Size.Height) { bullet.Pb.Dispose() ; bullets.Remove(bullet) ; } 
                }
            }
            return 0;
        }
        public void checkCollitionNave(List<clsPj> bullets, List<clsPj> naves, Label lblPoints,Form f,List<PictureBox> vidas, System.Windows.Forms.Timer timer,string playeName)
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
                            clsScores.saveScore(globalPoints,playeName);
                            timer.Stop();
                            frmFinJuego fin = new frmFinJuego();
                            f.Close();
                            fin.ShowDialog();
                            fin.BringToFront();
                        }
                    }
                    else if(bullet.Pb.Location.Y >= f.Size.Height)
                    {
                        bullet.Pb.Dispose();
                        bullets.Remove(bullet);
                    }
                }
            }
        }
    }
}
