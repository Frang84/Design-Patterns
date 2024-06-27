using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class Patron
    {
        private string details {set; get;}
        private string patronId = "";

        public Patron(string details, string patronId) { 
            this.details = details;
            this.patronId = patronId;
        }
        public Patron() {
            details = string.Empty;
            patronId = string.Empty;
        }
        public void search() {
            System.Console.WriteLine("serching");
        }
        public void request(){
            System.Console.WriteLine("Request");
        }
        public void payFine() { 
            System.Console.WriteLine("Pay fine"); 
        }
    }
}
