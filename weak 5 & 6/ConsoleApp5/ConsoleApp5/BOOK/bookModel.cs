using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.BOOK
{
    internal class bookModel
    {
        public int id;
        public string title;
        public string auther;

        public override string ToString()
        {
            return $"{id},{title},{auther}";
        }

    }
    
}
