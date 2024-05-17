using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsLevel
    {
        public int Level = 1;
        public void levelBar(ProgressBar bar, Label lblLevel,Form f)
        {
            bar.Maximum = 80 + (20 * Level);
            lblLevel.Text = Level.ToString();
        }
        public int levelPoints(ProgressBar bar, int points, Label lblLevel,Form f)
        {
            if (bar.Value + points > bar.Maximum)
            {
                bar.Value = 0;
                Level += 1;
                levelBar(bar, lblLevel,f);
            }
            else{bar.Value += points;}
            return Level;
        }
        
    }
}
