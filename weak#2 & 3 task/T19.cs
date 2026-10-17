using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace task18.cs
{
    class book
    {
        public string title;
        public string[] chapter = new string[6];
        public int pages;
        public int price;
        public string auther;
        public int bookmark;
        
        public book(string title, string[] chapter, int pages,int price,String auther,int bookmark)
        {
            this.title = title;
            this.chapter = chapter;
            this.pages = pages;
            this.price = price;
            this.auther = auther;
            this.bookmark = bookmark;
        }
        public bool avalibility(string check)
        {
            if(title == check)
            {
                Console.WriteLine("book is present :");
                return true;
            }
            else
            {
                Console.WriteLine("book is not avalible");
                return false;
            }
            
        }
        public void chap(int num)
        {
            Console.WriteLine(chapter[num]);
        }
        public void pageNo()
        {
            Console.WriteLine($"ur book mark is on {bookmark} ");
        }
        public void display()
        {
            Console.WriteLine($"title  = {title}\n chapater  = {chapter}\n pages = {pages}\n price = {price}\n auther = {auther}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] chapter = new string[6] { "human", "homo", "sapain" , "wren" ," martin" , "grow" };
            book b1 = new book("nature", chapter, 150, 500, "nipolin",67);
            b1.display();

            Console.WriteLine("\nenter the book name u want to check ");
            string check = Console.ReadLine();
            b1.avalibility(check);

            Console.WriteLine("\nenter the number of chapter u want to check name :");
            int num = int.Parse(Console.ReadLine());
            b1.chap(num);
            Console.WriteLine();
            b1.pageNo();

            
        }
    }
}
