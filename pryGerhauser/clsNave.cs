using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsNave
    {
        clsPj objPj;
        public List<PictureBox> vidas = new List<PictureBox>();
        public clsPj Create(int multiplicador)
        {
            objPj = new clsPj();
            PictureBox pbEnemy = new PictureBox();
            pbEnemy.Size = new Size(35, 35);
            pbEnemy.Image = Image.FromFile(@"../../../sprite/nave2.png");
            pbEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnemy.BackColor = Color.Transparent;
            objPj.Pb = pbEnemy;
            objPj.HP = 1;
            objPj.Lifes = 3;
            objPj.Point = -500;
            objPj.Damage = 25*multiplicador;
            return objPj;
        }
        public void spawn(clsPj nave,Form f)
        {
            nave.Pb.Location = new Point(f.Width/2,f.Height - (f.Height/6));
            f.Controls.Add(nave.Pb);   
        }
        public void move(string letra,clsPj player,Form f)
        {
            if (letra == "A" && player.Pb.Location.X>0){player.Pb.Location = new Point(player.Pb.Location.X - 15, player.Pb.Location.Y);}
            else if(letra == "D" && player.Pb.Location.X < f.Width - (player.Pb.Size.Width * 2)) 
            { player.Pb.Location = new Point(player.Pb.Location.X + 15, player.Pb.Location.Y);}
        }
        public List<PictureBox> lifes(Form f,int lifes)
        {
            PictureBox life;
            int x = 10;
            for (int i = 0; i < lifes - 1; i++)
            {
               
                life = new PictureBox();
                life.Location = new Point(x,f.Height-f.Height/8);
                life.Image = Image.FromFile(@"../../../sprite/nave2.png");
                life.BackColor = Color.Transparent;
                life.Size = new Size(25,25);
                life.SizeMode = PictureBoxSizeMode.Zoom;
                life.Name = $"vida{i}";
                vidas.Add(life);
                f.Controls.Add(life);
                x += life.Size.Width * 2;
            }
            return vidas;    
        }
    }
}
