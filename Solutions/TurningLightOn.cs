using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class TurningLightOn
    {
        public String[] pannel = { "0101", "1010", "0101", "1010" };
      
        public int minFlips(String[] pannel)
        {
           int flips = 0;

            for (int row = pannel.Length-1; row>=0; row--)
            {
                for(int col = pannel[row].Length-1; col>=0; col--)
                {
                    if (pannel[row][col] == '0')
                    {
                        pannel=flip(row, col,pannel);
                        flips++;
                    }
                }
            }
             Console.WriteLine(flips);
           return flips;
        }

        public String[] flip(int Row, int Col, String[] pannel) 
        { 
            for(int row=0; row<=Row; row++)
            {
                
                String bubles= pannel[row];
                String flipedbubles = "";

                for(int col=0; col<bubles.Length; col++)
                {
                   if(col<=Col)
                   {
                        if (bubles[col]=='0')
                            flipedbubles += "1";
                        else
                            flipedbubles += "0";
                   }
                   else
                    {
                        flipedbubles+= bubles[col];
                    }
                }

                pannel[row] = flipedbubles;
            }

            return pannel;
        }
    }
}
