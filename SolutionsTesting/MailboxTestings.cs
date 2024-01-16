using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace SolutionsTesting
{
    [TestClass]
    public class MailboxTestings
    {
        [TestMethod]
        public void impossible_verifyAddressCount_ReturnsTrue()
        {
            var mailbox = new Mailbox();

            String[] Collectins = {"AAAAAAABBCCCCCDDDEEE123456789", "ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890",
                                    "ABCDAAST"};
            List<String[]> Addresses = new List<String[]>();

            String[] addresses1 = { "123C", "123A", "123 ADA" }; Addresses.Add(addresses1);
            String[] addresses2 = { "2 FIRST ST", " 31 QUINCE ST", "606 BAKER" }; Addresses.Add (addresses2);
            String[] addresses3 = { "111 A ST", "A BAD ST", "B BAD ST" }; Addresses.Add(addresses3);

            int[] answers = {0,3,2};

            bool isvalid = true;
           
            for (int i=0; i < answers.Length; i++)
            {
                if (!(mailbox.impossible(Collectins[i], Addresses[i]) == answers[i]))
                {
                    isvalid= false; break;
                }
            }
            
            Assert.IsTrue(isvalid);
        }
    }
}
