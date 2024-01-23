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

            List<String[]> Boards = getBoards();
            int[] answers = getAnswer();

            bool IsValid = true;

            for (int i = 0; i < answers.Length; i++)
            {
                if (!(turningLightOn.minFlips(Boards[i]).Equals(answers[i])))
                {
                    IsValid = false; break;
                }
            }
            Assert.IsTrue(IsValid);
        }

        public int[] getAnswer()
        {
            return new int[] { 1, 0, 3, 7, 16};
        }

        public List<String[]> getBoards()
        {
            List<String[]> Boards = new List<String[]>();
            Boards.Add(new String[] { "0001111", "0001111", "1111111" });
            Boards.Add(new String[] { "1111111", "1111111", "1111111" });
            Boards.Add(new String[] { "01001" });
            Boards.Add(new String[] { "0101", "1010", "0101", "1010" });
            Boards.Add(new string[] { "1111", "1010", "1111", "1010" });
            

            return Boards;
        }
    }
}
