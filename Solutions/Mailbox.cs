using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Mailbox
    { 

        public String Collection = "";
        public String[] addresses = { "123C", "123A", "123 ADA" };

       
        public int impossible(String Collection, String[] addresses)
        {
            int impossible_address = 0;

            int length=Collection.Length;
            bool[] isused_charector = new bool[length];


            foreach (string address in addresses)
            {
                //initially all charactors are unused
                for(int isused_index=0; isused_index<length; isused_index++)
                {
                    isused_charector[isused_index] = false;
                }


                for (int address_index = 0; address_index < address.Length; address_index++)
                {
                    //if character is space than don't need to find it
                    bool character_found = address[address_index]==' ';

                    for (int Collection_index=0; Collection_index < length && !character_found; Collection_index++) 
                    {
                        if (!isused_charector[Collection_index] && Collection[Collection_index] == address[address_index])
                        {
                            isused_charector[Collection_index] = true;
                            character_found = true;
                            break;
                        }
                    }

                    if(!character_found)
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
