using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser
{
    public partial class frmJuego : Form
    {
        clsNave nave = new clsNave();
        clsPj player;
        clsBullet bullet = new clsBullet();
        clsCollision Collision = new clsCollision();
        clsBoss boss = new clsBoss();
        clsEnemigo enemy = new clsEnemigo();
        clsLevel level = new clsLevel();
        clsScores scores = new clsScores();
        
        List<clsPj> bullets = new List<clsPj>();
        List<clsPj> naves = new List<clsPj>();
        List<clsPj> enemies = new List<clsPj>();
        List<clsPj> enemyBullets = new List<clsPj>();
        List<clsPj> bossBullets = new List<clsPj>();
        List<clsPj> Boss = new List<clsPj>();
        List<PictureBox> vidas = new List<PictureBox>();
        
        Graphics g;
        Bitmap bm;

        int contador = 0;
        int contadorMove = 0;
        int multiplicador = 1;
        int pointsBoss = 0;
        int nivel = 1;
        int points = 0;
        Stopwatch sw = new Stopwatch();
        public frmJuego()
        {
            InitializeComponent();
            bm = new Bitmap(this.Width - 16, this.Height - 39);
            g = Graphics.FromImage(bm);
            g.Clear(Color.Black);
            this.BackgroundImage = bm;
            this.MaximumSize = new Size(414, 546);
            this.MinimumSize = new Size(414, 546);
            
            enemy.spawn(enemies, this);

            player = nave.Create(multiplicador);
            nave.spawn(player, this);
            naves.Add(player);
            vidas = nave.lifes(this, 3);
            
            timerDisparo.Start();
            sw.Start();
            
            level.levelBar(progressBarNivel, lblLevel, this);
            label3.Text = scores.getScore().ToString();
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            clsNave nave = new clsNave();
            if (e.KeyCode == Keys.D)
            {
                nave.move("D", player, this);
            }
            else if (e.KeyCode == Keys.A)
            {
                nave.move("A", player, this);
            }
            if (e.KeyCode == Keys.Space)
            {
                Size size = new Size(8, 14);
                bullets.Add(bullet.Create(@"../../../sprite/disparo1.png", size));
            }
        }
        private void timerDisparo_Tick_1(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, (int)sw.ElapsedMilliseconds);
            lblTime.Text = ts.ToString();
            
            if (lblPoints.Text != "") points = int.Parse(lblPoints.Text);
            else points = 0;
            
            enemyBullets = enemy.bullets;
            enemy.moveEnemy(enemies);
            bullet.move(bullets, this, player, 12);
            
            points = Collision.checkCollitionEnemy(bullets, enemies, lblPoints, progressBarNivel, lblLevel, this, points);
            Collision.checkCollitionNave(enemyBullets, naves, lblPoints, this, vidas, timerDisparo, lblPlayer.Text);
            pointsBoss = Collision.checkCollitionEnemy(bullets, Boss, lblPoints, progressBarNivel, lblLevel, this, points);

            enemy.shootEnemy(enemies, this);
            nivel = level.levelPoints(progressBarNivel, points, lblLevel, this);
            
            if (enemies.Count == 3) enemy.spawn(enemies, this);
            if (pointsBoss != 0) { nivel = level.levelPoints(progressBarNivel, pointsBoss, lblLevel, this); pointsBoss = 0; }
            if (nivel / Convert.ToDouble(nivel / 5) == 5 && Boss.Count < 1)
            {
                enemy.deleteEnemies(enemies, this);
                bullet.deleteBullets(bullets, this);
                clsPj newBoss = boss.boss(multiplicador);
                Boss.Add(newBoss);
                multiplicador++;
                contador = 0;
                boss.spawnBoss(Boss, this);
            }
            else
            {
                if (enemies.Count == 0 && Boss.Count == 0)
                {
                    enemy.spawn(enemies, this);
                }
            }
            if (Boss.Count != 0)
            {
                bossBullets = boss.bullets;
                boss.moveBoss(Boss, this);
                boss.shootBoss(Boss, this, multiplicador - 1);
                Collision.checkCollitionNave(bossBullets, naves, lblPoints, this, vidas, timerDisparo, lblPlayer.Text);
            }
        }
    }
}
