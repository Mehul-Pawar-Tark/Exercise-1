using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class DukeOnChessBoard

    { 
        public int n;
        public String initposition = "";
        public void setInput()
        {
            n = 8;
            initposition = "a8";
        }

        public String dukePath(int n,String initposition)
        {
            bool[,] visited_matrix=new bool[n,n];


            //find initial row and column positions
            int col_position = (int)(initposition[0]-'a');
            int row_position = (int)(initposition[1]-'1');

            //initialize visited matrix
            for(int row=0; row<n; row++)
            {
                for(int col=0; col<n; col++)
                {
                     visited_matrix[row,col] = (row == row_position && col == col_position);    
                }
            }

            //currently path is empaty
            String path = "";
           
            bool top_available = true;       bool bottom_available = true;
            bool left_available = true;      bool right_available = true;

            while(top_available || bottom_available || left_available || right_available) 
            {

                path += (char)((int)('a') + col_position);
                path += (char)((int)('1') + row_position)+"-";

                visited_matrix[row_position, col_position] = true;

                char ch = (char)((int)('a')+row_position);
               
                top_available = (row_position-1>=0 && !visited_matrix[row_position-1,col_position]); 
                bottom_available = (row_position + 1 <n && !visited_matrix[row_position+1, col_position]);
                left_available = (col_position - 1 >= 0 && !visited_matrix[row_position, col_position-1]);
                right_available=(col_position + 1 <n && !visited_matrix[row_position, col_position+1]);

                if(right_available)
                    col_position++;

                else if(bottom_available)
                    row_position++;
                
                else if(top_available)
                    row_position--;
                
                else if(left_available)
                    col_position--;

            }
            path=path.Substring(0,path.Length-1);

            if(path.Length>40)
            {
                path=path.Substring(0,20)+"..."+path.Substring(path.Length-20);
            }




            return path;
        }
    }
}
