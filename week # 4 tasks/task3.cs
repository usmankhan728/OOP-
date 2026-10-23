using System.Globalization;
using System.Runtime.InteropServices;

namespace task3.cs
{
    class book
    {
        public String title;
        public bool isavalible;
        public book(String title)
        {
            this.title = title;
            this.isavalible = true;
        }
    }
    class library
    {
        public bool borrowbook (book b)
        {
            if (b.isavalible)
            {
                Console.WriteLine("book is present :");
                b.isavalible = false;
                return true;
            }
            Console.WriteLine("book is borrowed :");
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b = new book("c# basic");
            library one = new library();
            one.borrowbook(b);
            Console.WriteLine("after :");
            one.borrowbook(b);
        }
    }
}
