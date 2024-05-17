using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGerhauser
{
    internal class clsScores
    {
        public void saveScore(int score,string playerName)
        {
            StreamWriter AD = new StreamWriter("Scores.txt", true);
            AD.Write(playerName + ",");
            AD.Write(score.ToString());
            AD.Write('\n');

            AD.Close();
            AD.Dispose();
        }
        public int getScore()
        {
            StreamReader sr = new StreamReader("Scores.txt");
            string linea = "";
            string[] data;
            int auxScore = 0;

            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                data = linea.Split(",");
                if(linea != "")
                {
                    if (Convert.ToInt32(data[1]) > auxScore)
                    {
                        auxScore = Convert.ToInt32(data[1]);
                    }
                }
            }

            sr.Close();
            sr.Dispose();
            return auxScore;
        }
    }
}
