using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Mailbox
    { 
        public int impossible(String collection, String[] addresses)
        {
            int impossible_address = 0;

            foreach (string address in addresses)
            {
                char[] Collection_Arr=collection.ToCharArray();
                char[] Address = address.ToCharArray();

                foreach(char character_of_address in Address)
                {
                    //if character is space than don't need to find it
                    if (character_of_address == ' ') continue;

                    int index = Array.IndexOf(Collection_Arr, character_of_address);

                    if(index!=-1)
                        Collection_Arr[index] ='-';
                    
                    else
                    {
                        impossible_address++;
                        break;
                    }
                }

            }

            return impossible_address;
        }
    }
}
