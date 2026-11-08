using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.BOOK
{
    internal class bookRepository
    {
        private string filepath = "file.txt";
        public void savefile(bookModel b)
        {
            using (StreamWriter writer = new StreamWriter(filepath,true))
            { 
                    writer.WriteLine(b.ToString());
            }
        }

        public List<bookModel> getall()
        {
            List<bookModel> data = new List<bookModel>();

            if (File.Exists(filepath))
            {

                using (StreamReader reader = new StreamReader(filepath, true))
                {
                    string line;
                    if ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        while (parts.Length <= 3)
                        {
                            bookModel b = new bookModel();
                            b.id = int.Parse(parts[0]);
                            b.title = parts[1];
                            b.auther = parts[2];
                            data.Add(b);
                        }
                    }
                }
            }
            return data;
        }
    }
}
