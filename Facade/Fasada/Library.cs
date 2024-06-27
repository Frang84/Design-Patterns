using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class Library
    {
        private string location;
        private string librarianId;

        public Library(string location, string librarianId)
        {
            this.location = location;
            this.librarianId = librarianId;
        }   
        public Library()
        {
            this.location = string.Empty;
            this.librarianId= string.Empty; 
        }
    }

}
