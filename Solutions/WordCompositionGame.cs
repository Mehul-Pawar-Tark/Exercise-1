using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class WordCompositionGame
    {
        public String score(String[] listA, String[] listB, String[] listC)
        { 

            String Score = "";
            Score+=firstScore(listA, listB, listC) + "/";
            Score+=firstScore(listB, listA, listC) + "/";
            Score+=firstScore(listC, listB, listA);

            return Score;
        }

        public int firstScore(String[] listA, String[] listB, String[] listC)
        {

            int first_score = 0;

            for (int i = 0; i < listA.Length; i++)
            {
                if ((!listB.Contains(listA[i])) && (!listC.Contains(listA[i])))
                    first_score += 3;
                
                else if ((!listB.Contains(listA[i])) || (!listC.Contains(listA[i])))
                    first_score += 2;
                
                else
                    first_score++;
                
            }

            return first_score;
        }
    }
}
