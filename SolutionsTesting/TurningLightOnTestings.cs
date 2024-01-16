using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class TurningLightOnTestings
    {
        [TestMethod]
        public void minflip_Compareflips_ReturnsTrue()
        {
            var turningLightOn = new TurningLightOn();

            List<String[]> Boards = new List<String[]>();
            String[] board1 = { "0001111", "0001111", "1111111" };
            Boards.Add(board1);
            String[] board2 = { "1111111", "1111111", "1111111" };
            Boards.Add(board2);
            String[] board3 = { "01001" };
            Boards.Add(board3);
            String[] board4 = { "0101", "1010", "0101", "1010" };
            Boards.Add(board4);



            int[] answers = { 1, 0, 3, 7 };

            bool IsValid = true;
           
            
            
            
            for (int i=0; i<answers.Length; i++) 
            {
                if (!(turningLightOn.minFlips(Boards[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }
            

            Assert.IsTrue(IsValid);

        }
    }
}
