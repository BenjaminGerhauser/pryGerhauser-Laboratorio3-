using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGerhauser
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
            bm = new Bitmap(this.Width - 16, this.Height - 39);
            g = Graphics.FromImage(bm);
            g.Clear(Color.Black);
            this.BackgroundImage = bm;
            this.MaximumSize = new Size(414, 546);
            this.MinimumSize = new Size(414, 546);
            //for (int i = 0; i < 6; i++)
            //{
            //    clsPj nuevo;
            //    nuevo = enemy.Create();
            //    enemies.Add(nuevo);
            //}
            enemy.spawn(enemies, this);
            player = nave.Create();
            nave.spawn(player, this);
            naves.Add(player);
            vidas = nave.lifes(this,3);
            timerDisparo.Start();
            sw.Start();
            level.level = 1;
            
        }
        clsNave nave = new clsNave();
        clsPj player;
        clsBullet bullet = new clsBullet();
        clsCollision Collision = new clsCollision();
        clsBoss boss = new clsBoss();
        clsEnemigo enemy = new clsEnemigo();
        clsLevel level = new clsLevel();
        List<clsPj> bullets = new List<clsPj>();
        List<clsPj> naves = new List<clsPj>();
        List<clsPj> enemies = new List<clsPj>();
        List<clsPj> enemyBullets = new List<clsPj>();
        List<clsPj> Boss = new List<clsPj>();
        Graphics g;
        Bitmap bm;
        List<PictureBox> vidas = new List<PictureBox>();
        int contador = 0;
        int contadorMove = 0;
        int multiplicador = 1;
        int pointsLevel;
        

        Stopwatch sw = new Stopwatch();

        private void frmJuego_KeyDown_1(object sender, KeyEventArgs e)
        {
            clsNave nave = new clsNave();
            if (e.KeyCode == Keys.D)
            {
                nave.move("D", player,this);
            }
            else if (e.KeyCode == Keys.A)
            {
                nave.move("A", player,this);
            }
            if (e.KeyCode == Keys.Space)
            {
                bullets.Add(bullet.Create("sprite/disparo1.png"));
            }
        }
        private void timerDisparo_Tick_1(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)sw.ElapsedMilliseconds);
            contador++;
            List<clsPj> copyEnemies = new List<clsPj>(enemies);
            List<clsPj> copyBullets = new List<clsPj>(bullets);
            List<clsPj> copyNaves = new List<clsPj>(naves);

            enemyBullets = enemy.bullets;
            label3.Text = ts.Seconds.ToString();
            //enemy.moveEnemy(enemies);
            if (level.endLevel == true && Boss.Count < 1)
            {
                enemy.deleteEnemies(enemies, this);
                clsPj newBoss = boss.boss(multiplicador);
                Boss.Add(newBoss);
                multiplicador++;
                contador = 0;
                boss.spawnBoss(Boss, this);
                sw.Restart();
                level.level++;
                level.pointAux = 0;
            }
            else
            {
                if (enemies.Count == 0 && Boss.Count ==0)
                {
                    //for (int i = 0; i < 6; i++)
                    //{
                    //    clsPj nuevo;
                    //    nuevo = enemy.Create();
                    //    enemies.Add(nuevo);
                    //}
                    enemy.spawn(enemies, this);
                    sw.Start();
                }
            }
            bullet.move(bullets, this, player, 12);
            Collision.checkCollitionEnemy(bullets, enemies, lblPoints, pointsLevel,progressBar1);
            Collision.checkCollitionNave(enemyBullets, naves, lblPoints, this, vidas);
            enemy.shootEnemy(enemies, this);
            Collision.checkCollitionEnemy(bullets, Boss, lblPoints,pointsLevel,progressBar1);
            if (Boss.Count != 0) boss.moveBoss(Boss, this);
        }
    }
}
