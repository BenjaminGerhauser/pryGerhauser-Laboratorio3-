using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsPj
    {
        private int hp;
        private int damage;
        private int point;
        private int lifes;
        private PictureBox pb;

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Point
        {
            get { return point; }
            set { point = value; }
        }
        public int Lifes
        {
            get { return lifes; }
            set { lifes = value; }
        }
        public PictureBox Pb
        {
            get { return pb; }
            set { pb = value; }
        }

    }
}
