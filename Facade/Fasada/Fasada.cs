using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class Fasada
    {
        private BookDatabase db;
        private Patron patron;
        private PatronRecord record;
        private Vendor vendor;
        private Librarian librarian;
        private Library library;

        public Fasada() { 
            db = new BookDatabase();
            patron = new Patron();
            record = new PatronRecord();
            vendor = new Vendor();
            librarian = new Librarian();
            library = new Library();
        }
        public void issueStatus()
        {
            librarian.issueStatus();
        }
        public void update()
        {
            db.update();
        }
        public void search()
        {
            patron.search();
        }
        public void supplyBooks()
        {
            vendor.supplyBook();
        }
        public void retriveMember () { 
            record.retriveMember();
        }
    }
}
