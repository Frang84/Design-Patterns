using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class PatronRecord
    {
        private string patronId;
        private string type;
        private string dateOfMembership;
        private string noBooksIssued;
        private string name;
        private string address;
        private string phoneNo;
        private string finesOwed;

        public void retriveMember()
        {
            Console.WriteLine("retrive member");
        }
        public void increaseMember()
        {
            Console.WriteLine("increase member");
        }
        public void decreaseBookIssued()
        {
            Console.WriteLine("decrease book issued");
        }
        public void payFine()
        {
            Console.WriteLine("pay fine");
        }
    }
}
