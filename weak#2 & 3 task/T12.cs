using System;
using System.Globalization;

namespace task12.cs
{
    class book
    {
        public int bookid;
        public string name;
        public String auther;
        public book(int bookid, String name, String auther)
        {
            this.bookid = bookid;
            this.name = name;
            this.auther = auther;
        }
        
     }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<book> l = new List<book>();
                Console.WriteLine("ENTER BOOK ID :");
                int bookid = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER BOOK NAME :");
                string name = Console.ReadLine();
                Console.WriteLine("ENTER BOOK AUTHER NAME :");
                string auther = Console.ReadLine();

                book books = new book(bookid, name, auther);
                l.Add(books);
                Console.WriteLine("ADD NEW BOOK :");

            Console.WriteLine("ENTER BOOK ID :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER BOOK NAME :");
            string name2 = Console.ReadLine();
            Console.WriteLine("ENTER BOOK AUTHER NAME :");
            string auther2 = Console.ReadLine();

            book books2 = new book(id, name2, auther2);
            l.Add(books2);
            
            for(int i = 0; i < l.Count; i++)
            {
                Console.WriteLine($"Name : {l[i].name} , Bookid : {l[i].bookid} , Bookauthor : {l[i].auther}");
            }
            }
        }
}
