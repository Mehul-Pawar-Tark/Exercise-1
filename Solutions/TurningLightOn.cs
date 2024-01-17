using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class TurningLightOn
    {
       
        public int minFlips(String[] board)
        {
            int Row = board.Length;
            int Column = board[0].Length;

            int[,] values = new int[Row,Column];

            for (int row =Row - 1; row >= 0; row--)
            {
                for (int column = Column - 1; column >= 0; column--)
                {
                    int val = 0;
                    if ((row + 1) < Row)
                        val = values[(row + 1), column] > val ? values[(row + 1), column] : val;
                    if ((column + 1) < Column)
                        val = values[row , (column+1)] > val ? values[row , (column+1)] : val;

                    if(val%2==0 && board[row][column]=='0')
                        val++;
                 
                    if (val % 2 == 1 && board[row][column] == '1')
                        val++;
                   
                    values[row ,column] = val;

                }
            }
            return values[0,0];
        }

    }
}
