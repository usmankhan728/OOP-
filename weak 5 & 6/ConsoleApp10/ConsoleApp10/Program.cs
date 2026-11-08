using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class auther
    {
        public string name;
        public auther(string name)
        {
            this.name = name;
        }
    }
    class book
    {
        public string title;
        public auther auther;
        public book(string title, auther auther)
        {
            this.title = title;
            this.auther= auther;
        }
        public void display()
        {
            Console.WriteLine("BOOK => " + title);
            Console.WriteLine("auther => " + auther.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            auther a1 = new auther("ROBERT");
            book b1 = new book("think", a1);
            b1.display();
        }
    }
}
