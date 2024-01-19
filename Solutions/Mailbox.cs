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


            // count all small charectors,capital charectors and digits of collection 
            int[] Collectin_small_charector = new int[26];
            int[] Collectin_capital_charector = new int[26];
            int[] Collectin_digits = new int[10];

            for(int index=0; index<collection.Length; index++)
            {
                if (collection[index] >= 'a' && collection[index] <= 'z')
                    Collectin_small_charector[((int)(collection[index])) - ((int)('A'))]++;
                if (collection[index] >= 'A' && collection[index] <= 'Z')
                    Collectin_capital_charector[((int)(collection[index])) - ((int)('A'))]++;
                if (collection[index] >= '0' && collection[index] <= '9')
                    Collectin_digits[((int)(collection[index])) - ((int)('0'))]++;
            }

            foreach (string address in addresses)
            {
                // count all small charectors,capital charectors and digits of address
                int[] small_charector = new int[26];
                int[] capital_charector = new int[26];
                int[] digits = new int[10];

                for (int index = 0; index < address.Length; index++)
                {
                    if (address[index] >= 'a' && address[index] <= 'a')
                        small_charector[((int)(address[index])) - ((int)('A'))]++;
                    if (address[index] >= 'A' && address[index] <= 'Z')
                        capital_charector[((int)(address[index])) - ((int)('A'))]++;
                    if (address[index] >= '0' && address[index] <= '9')
                        digits[((int)(address[index])) - ((int)('0'))]++;
                }


                // check address is posible or not
                bool posible = true;
                for(int index = 0; index < Collectin_digits.Length; index++)
                {
                    if (digits[index] > Collectin_digits[index])
                    {
                        posible = false;
                        break;
                    }
                }

                for (int index = 0; index < Collectin_small_charector.Length && posible; index++)
                {
                    if (small_charector[index] > Collectin_small_charector[index])
                    {
                        posible = false;
                        break;
                    }
                }

                for (int index = 0; index < Collectin_capital_charector.Length && posible; index++)
                {
                    if (capital_charector[index] > Collectin_capital_charector[index])
                    {
                        posible = false;
                        break;
                    }
                }

                if(!posible) { impossible_address++; }

            }

            return impossible_address;
        }
        
    }
}
