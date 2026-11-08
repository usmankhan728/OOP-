using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.BOOK
{
    internal class bookService
    {
        bookRepository repo = new bookRepository();
        
        public void addbook(bookModel b)
        {
            repo.savefile(b);
        }

        public List<bookModel> fetch()
        {
           return repo.getall();
        }
    }
}
