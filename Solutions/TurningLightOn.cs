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

            int Total_changes = 0;
            bool[] val=new bool[Column];

            for (int row = Row - 1; row >= 0; row--)
            {
                bool col_change = false;
                for (int column = Column - 1; column >= 0; column--)
                {
                    bool change = val[column]!=col_change;

                    if ((!change) && board[row][column] == '0')
                    {
                        change = !change;           
                        col_change = !col_change;
                        Total_changes++;

                    }
                    else if (change && board[row][column] == '1')
                    {
                        change = !change;
                        col_change = !col_change;
                        Total_changes++;
                    }

                    val[column] = change;
                }
            }

            return Total_changes;
        }

        public int minFlips1(String[] board)
        {
            int Row = board.Length;
            int Column = board[0].Length;

            int[] value= new int[Column];

            for (int row = Row - 1; row >= 0; row--)
            {
                int column_change = 0;

                for (int column = Column - 1; column >= 0; column--)
                {
                    int changes = value[column] + column_change;

                    if (changes % 2 == 0 && board[row][column] == '0')
                    {
                        column_change++;
                        changes++;

                    }
                    else if (changes % 2 == 1 && board[row][column] == '1')
                    {
                        column_change++;
                        changes++;
                    }

                    value[column] = changes;
                }
            }

            return value[0];
        }
       
    }
}
