using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp6.STUDENT
{
    internal class studentRepository
    {
        public string filepath = "file.txt";
        public void addstu(studentModel s)
        {
            using(StreamWriter  sw = new StreamWriter(filepath,true))
            {
                sw.WriteLine($"{s.id} , {s.name} , {s.feepaid}");
            }
        }
        public List<studentModel> fetch()
        {
            List<studentModel> students = new List<studentModel>();
            
            if (File.Exists(filepath))
            {
                using (StreamReader read = new StreamReader(filepath))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if(parts.Length >= 3)
                        {
                            studentModel stu = new studentModel();
                            stu.id = int.Parse(parts[0]);
                            stu.name = parts[1];
                            stu.feepaid = double.Parse(parts[2]);
                            
                           students.Add(stu);
                        }
                    }
                }
            }
            return students;
        }
    }
}
