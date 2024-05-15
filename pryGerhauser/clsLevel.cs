using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsLevel
    {
        public int level { get; set; }
        public bool endLevel { get; set; }
        public int pointAux = 0;
        public void levelBar(ProgressBar bar)
        {
            bar.Maximum = 80 + (20 * level);
        }
        public void levelPoints(ProgressBar bar,int points) 
        {
            pointAux = bar.Value + points;
            if (pointAux >= bar.Maximum)endLevel = true;
            else { bar.Value = pointAux; endLevel = false; }
                
        }
    }
}
