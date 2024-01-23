using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class DukeOnChessBoardtesting
    {
        [TestMethod]
        public void duckpath_CheckPath_ReturnsTrue()
        {
            var dukeOnChessBoard=new DukeOnChessBoard();

            int[] N = getN();
            String[] InitPosition =  getInitpositions();

            String[] Answers= getAnswers();

            bool IsValid = true;

            for(int i = 0; i < N.Length; i++)
            {
                if (!(dukeOnChessBoard.dukePath(N[i], InitPosition[i]).Equals(Answers[i])))
                {
                    IsValid = false; break;
                }

            }
            Assert.IsTrue(IsValid);   
        }
        public String[] getAnswers() 
        {
           return new String[] {"b2-c2-c3-b3-a3-a2-a1-b1-c1" , "d4-d3-d2-d1-c1-c2-c3...b3-b2-b1-a1-a2-a3-a4",
                "a2-b2-c2-c3-b3-a3", "d3-d4-c4-c3-c2-d2-d1...b2-b3-b4-a4-a3-a2-a1"};
        }
        public String[] getInitpositions()
        {
            return new String[] { "b2", "d4", "a2", "d3" };
        }
        public int[] getN()
        {
            return new int[] { 3, 4, 3, 4 };
        }

    }
}
