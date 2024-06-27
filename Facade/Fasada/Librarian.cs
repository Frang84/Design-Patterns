using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class Librarian : Patron
    {
        private string name;
        private string librarianId;

        public Librarian(string name, string librarianId) {
            this.name = name;
            this.librarianId = librarianId;
        }
        public Librarian() {
            this.name = string.Empty;
            this.librarianId = string.Empty;
        }

        public void issueStatus(){
            Console.WriteLine("Issue Status");
        }
        public void searchBook(){
            Console.WriteLine("Serch Book");
        }
        public void verifyMember(){
            Console.WriteLine("Member virify");
        }
        public void issueBook(){
            Console.WriteLine("book issue");
        }
        public void payment() {
            Console.WriteLine("Payment");
        }
    }
}
