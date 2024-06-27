using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class Vendor
    {
        private string bookDetails;

        public Vendor(string bookDetails) {
            this.bookDetails = bookDetails;
        }
        public Vendor() {
            this.bookDetails = string.Empty;
        }
        public void supplyBook()
        {
            Console.WriteLine("supply book");
        }
        public void paymentDetails()
        {
            Console.WriteLine("payment details: "+ this.paymentDetails);
        } 

    }
}
