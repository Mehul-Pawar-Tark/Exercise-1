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

            String[] Collectins = getCollections();
            List<String[]> Addresses = getAddresses();

            int[] answers = getAnswer();

            bool isvalid = true;

            for (int i = 0; i < answers.Length; i++)
            {
                if (!(mailbox.impossible(Collectins[i], Addresses[i]) == answers[i]))
                {
                    isvalid = false; break;
                }
            }

            Assert.IsTrue(isvalid);
        }

        public List<String[]> getAddresses() 
        {
            List<String[]> Addresses = new List<String[]>();

            Addresses.Add(new String[] { "123C", "123A", "123 ADA" });
            Addresses.Add(new String[] { "2 FIRST ST", " 31 QUINCE ST", "606 BAKER" });
            Addresses.Add(new String[] { "111 A ST", "A BAD ST", "B BAD ST" });

            return Addresses;
        }
        public int[] getAnswer()
        {
            return new int[] { 0, 3, 2 };
        }
        public String[] getCollections() 
        {
          return new String[] {"AAAAAAABBCCCCCDDDEEE123456789", "ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890",
                                    "ABCDAAST"};
        }
    }
}
