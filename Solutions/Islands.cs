using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Islands
    {
        public String[] kingdom= {"#...#.....","##..#...#."};


        public int beachLength(String[] kingdom)
        {
            int totalArea = 0;
            int totalrows = kingdom.Length;

            for (int row = 0; row < totalrows; row++)
            {
                String line = kingdom[row];

                if (row % 2 == 0)
                {
                    String previous = "";
                    if (row - 1 >= 0)
                        previous = kingdom[row - 1];

                    String next = "";
                    if (row + 1 < totalrows)
                        next = kingdom[row + 1];

                    
                    for (int col = 0; col < line.Length; col++)
                    {
                        if (col - 1 >= 0 && (line[col] !=line[col - 1]))
                            totalArea++;
                        
                        if (col + 1 < line.Length && (line[col] !=line[col + 1]))
                            totalArea++;
                        
                        if (previous != "")
                        {
                            if(col<previous.Length && (line[col] !=previous[col]))
                                totalArea++;
                            
                            if(col-1>=0 && (line[col] !=previous[col-1]))
                                totalArea++;   
                        }
                        if(next!="")
                        {
                            
                            if(col<next.Length && (line[col] !=next[col]))
                            {
                                totalArea++;
                            }
                            if(col-1>=0 && (line[col] !=next[col-1]))
                            {
                                totalArea++;
                            }
                        }
                        
                        

                    }
                }
                
                else
                {
                    
                    String previous = "";
                    if (row - 1 >= 0)
                        previous = kingdom[row - 1];

                    String next = "";
                    if (row + 1 < totalrows)
                        next = kingdom[row + 1];

                    
                    for (int col = 0; col < line.Length; col++)
                    {
                        if (col - 1 >= 0 && (line[col] !=line[col - 1]))
                            totalArea++;

                        if (col + 1 < line.Length && (line[col] !=line[col + 1]))
                            totalArea++;

                        
                        if (previous != "")
                        {
                            if (col < previous.Length && (line[col] !=previous[col]))
                            {
                                totalArea++;
                            }
                            if (col + 1 < previous.Length && (line[col]!=previous[col + 1]))
                            {
                                totalArea++;
                            }
                        }
                        if (next != "")
                        {
                            if (col < next.Length && (line[col] !=next[col] ))
                            {
                                totalArea++;
                            }
                            if (col + 1 < previous.Length && (line[col] != next[col+1]))
                            {
                                totalArea++;
                            }
                        }

                    }
                      
                }
               
            }
            
            return totalArea/2;
        }
    }
}
