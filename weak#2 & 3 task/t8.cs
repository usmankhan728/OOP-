using System.Net;

namespace task8.cs
{
    class Book
    {
        private int bookId;
        private string title;
        private string author;

        public Book(int id, string title, string author)
        {
            bookId = id;
            this.title = title;
            this.author = author;
        }

        public void DisplayBook()
    {
        Console.WriteLine("Book ID: " + bookId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("--------------------");
    }

    public int GetBookId()
    {
        return bookId;
    }
}
internal class Program
    {
        static Book AddBook()
        {
            Console.Write("Enter Book ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Book b = new Book(id, title, author);

            return b;
        }

        static void ShowBooks(Book[] books, int count)
        {
            if (count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                books[i].DisplayBook();
            }
        }

        static void RemoveBook(Book[] books, ref int count)
        {
            Console.Write("Enter Book ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (books[i].GetBookId() == id)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Book not found!");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                books[i] = books[i + 1];
            }

            count--;

            Console.WriteLine("Book removed successfully!");
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[100];
            int count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Display All Books");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        books[count] = AddBook();
                        count++;
                        break;

                    case 2:
                        ShowBooks(books, count);
                        break;

                    case 3:
                        RemoveBook(books, ref count);
                        break;

                    case 4:
                        Console.WriteLine("Program Ended.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 4);
        }
    }
}
