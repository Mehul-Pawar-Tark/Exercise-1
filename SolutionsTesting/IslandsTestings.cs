using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class IslandsTestings
    {
        [TestMethod]
        public void beachLand_comareArea_ReturnTrue()
        {
            var islands = new Islands();

            List<String[]> kingdoms = getKingdoms();
           
            int[] answers = getanswers();

            bool IsValid = true;

            for (int i = 0; i < answers.Length; i++)
            {
                if (!(islands.beachLength(kingdoms[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }

            Assert.IsTrue(IsValid);
        }

        public int[] getanswers()
        {
            return new int[] {4, 19, 15, 24}; 
        }
        public List<String[]> getKingdoms() 
        {
            List<String[]> kingdoms =new List<String[]>();
            kingdoms.Add(new String[] { ".#...#.." });
            kingdoms.Add(new String[] { "..#.##", ".##.#.", "#.#..." });
            kingdoms.Add(new String[] { "#...#.....", "##..#...#." });
            kingdoms.Add(new String[] { "....#.", ".#....", "..#..#", "####.." });

            return kingdoms;
        }
    }
}
