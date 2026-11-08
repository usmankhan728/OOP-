using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class document
    {
        private string title;
        private List<paragraph> paragraphs;
        public document(string title)
        { 
            paragraphs = new List<paragraph>();
        }

        public void addparagraph(string content)
        {
            paragraphs.Add(new paragraph(content));
        }

        public void print()
        {
            Console.WriteLine($"document : {title}");
            foreach(paragraph paragraph in paragraphs)
            {
                paragraph.print();
            }
        }
    }

    public class paragraph
    {
        private string content;
        public paragraph(string content)
        {
            this.content = content;
        }
        public void print()
        {
            Console.WriteLine(content);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            document docx = new document("MY DOCX ");

            docx.addparagraph("this is my first content :");
            docx.addparagraph("this is my second content :");
            docx.print();
        }
    }
}
