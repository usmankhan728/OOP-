using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task16.cs
{
    class book
    {
        public string title;
        public int pages;
        public int price;

        public book(string title, int pages, int price)
        {
            this.title = title;
            this.pages = pages;
            this.price = price;

        }

        public void print()
        {
            Console.WriteLine($"book title is {title} in which pages are {pages} and price is {price}");
        }
    }
    internal class Program
    {
        static void display(List<book> data)
        {
            foreach (book book in data)
            {
                book.print(); 
            }
        }
        static void Main(string[] args)
        {
            List<book> data = new List<book>();

            book one = new book("see", 200, 450);
            book two = new book("sapian", 150, 330);
            book three = new book("grow", 234, 500);
            book four = new book("rich", 185, 300);

            data.Add(one); data.Add(two); data.Add(three); data.Add(four);

            display(data);

            int cheapest = data[0].price;
            
            foreach (book book in data)
            {
               for(int i = 1; i < data.Count; i++)
                {
                    if (data[i].price < cheapest)
                    {
                        cheapest = data[i].price;
                        
                    }
                }  
            }


            Console.WriteLine();

            Console.WriteLine($"cheapest book is {cheapest}"); 




        }
    }
}
