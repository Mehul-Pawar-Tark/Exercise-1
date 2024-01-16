using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class WordCompositionGame
    {
        public String[] list1 = { "cat", "dog", "pig", "mouse" };
        public String[] list2 = { "cat", "pig" };
        public String[] list3 = {"dog", "cat"};

    public String score(String[] list1, String[] list2, String[] list3)
        { 

            String Score = "";
            Score+=firstScore(list1, list2, list3) + "/";
            Score+=firstScore(list2, list1, list3) + "/";
            Score+=firstScore(list3, list2, list1);

            return Score;
        }

        public int firstScore(String[] list1, String[] list2, String[] list3)
        {

            int first_score = 0;

            for (int i = 0; i < list1.Length; i++)
            {
                if ((!list2.Contains(list1[i])) && (!list3.Contains(list1[i])))
                    first_score += 3;
                
                else if ((!list2.Contains(list1[i])) || (!list3.Contains(list1[i])))
                    first_score += 2;
                
                else
                    first_score++;
                
            }

            return first_score;
        }
    }
}
