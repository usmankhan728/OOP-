using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace task11.cs
{
    class book
    {
        public string title;
        public string auther;

        public book(String title, String auther)
        {
            this.title = title;
            this.auther = auther;
        }

        public void display()
        {
            Console.WriteLine($"the book {title} is written by {auther}");
        }

    }
    internal class Program
    {
        static void input()
        {
            Console.WriteLine("enter book name :");
            string title = Console.ReadLine();
            Console.WriteLine("enter auther name :");
            String auther = Console.ReadLine();
        }

        static void view(book[] mybook, int count)
        {
            for(int i=0; i<count; i++)
            {
                Console.WriteLine(mybook + " ");
            }
        }
        static void Main(string[] args)
        {
            book[] mybook = new book[10];
            int count = 0;

            Console.WriteLine("enter 1 to add book 2 to diplay books and 3 to exit :");
            int choice = int.Parse(Console.ReadLine());
            while(choice != 3)
            {
                if (choice == 1)
                {
                    input();
                    mybook[count] = new book("title", "auther");
                    count++;
                    continue;
                }
                else if (choice == 2)
                {
                    view(mybook, count);
                }
            }



        }
    }
}
