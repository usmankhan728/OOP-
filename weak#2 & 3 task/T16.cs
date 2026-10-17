using System.Globalization;
using System.Net.Http.Headers;

namespace task15.cs
{
    class medicine
    {
        public String title;
        public int expiry;
        public int price;

        public medicine(String title, int expiry, int price)
        {
            this.title = title;
            this.expiry = expiry;
            this.price = price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<medicine> data = new List<medicine>();
            StreamReader sr = new StreamReader("medicine.txt",true);
            string line;
            
            while ((line = sr.ReadLine()) != null)
            {
                
                    string[] part = line.Split(',');

                    medicine info = new medicine(part[0], int.Parse(part[1]), int.Parse(part[2]));
                    data.Add(info);
                
                
            }
            sr.Close();

            foreach(medicine info in data)
            {
                Console.WriteLine($"ur data is : {info.title} \n {info.expiry} \n {info.price}");
            }

        }
    }
}





