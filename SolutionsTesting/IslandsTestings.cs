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

            List<String[]> kingdoms= new List<String[]>();
            String[] kingdome1 = { ".#...#.." }; kingdoms.Add(kingdome1);
            String[] kingdome2 = {"..#.##",".##.#.","#.#..."}; kingdoms.Add (kingdome2);
            String[] kingdome3 = {"#...#.....","##..#...#."}; kingdoms.Add(kingdome3);
            String[] kingdome4 = {"....#.",".#....","..#..#","####.."};kingdoms.Add(kingdome4);


            int[] answers = { 4,19,15,24};

            bool IsValid = true;
       
            for (int i = 0; i < answers.Length; i++) 
            {
                if (!(islands.beachLength(kingdoms[i]).Equals(answers[i])))
                {
                    IsValid = false;    break;
                }
            }

            Assert.IsTrue(IsValid);
        }
    }
}
