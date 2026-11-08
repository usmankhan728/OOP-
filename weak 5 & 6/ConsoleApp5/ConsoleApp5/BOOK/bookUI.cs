using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.BOOK
{
    internal class bookUI
    {
        bookService service = new bookService();
        List<bookModel> books = new List<bookModel>();
        public void start()
        {
            while (true)
            {
                Console.WriteLine("==========LIBRARY==========");
                Console.WriteLine("1.ADD NEW BOOK TO LIBRARY ");
                Console.WriteLine("2.VIEW ALL BOOKS ");
                Console.WriteLine("3.BORROW A BOOK ");
                Console.WriteLine("4.RETURN A BOOK ");
                Console.WriteLine("5.EXIT ");

                Console.Write("Enter ur option :");
                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    bookModel b = usermenu();
                    service.addbook(b);
                    Console.Write("book added succefully ");
                    Console.ReadKey();
                }
                else if(option == 2)
                {
                    total();
                }
                else if (option == 3)
                {

                }
                else if (option == 4)
                {

                }
                else if (option == 5)
                {
                    break;
                }
            }
            
        }

        public bookModel usermenu()
        {
            bookModel b = new bookModel();

            Console.WriteLine("ENTER BOOK ID ");
            b.id = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER BOOK TITLE ");
            b.title = Console.ReadLine();
            Console.WriteLine("ENTER BOOK AUTHER ");
            b.auther = Console.ReadLine();


            books.Add(b);

            return b;

        }
        public void total()
        {
            Console.Clear();
            var result = service.fetch();

            Console.WriteLine("\n--- ALL BOOKS IN LIBRARY ---");

            if (result.Count == 0)
            {
                Console.WriteLine("No books found in the library yet!");
            }
            else
            {
                foreach (var value in result)
                {
                    Console.WriteLine($"{value.id} , {value.title} , {value.auther}");
                }
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
