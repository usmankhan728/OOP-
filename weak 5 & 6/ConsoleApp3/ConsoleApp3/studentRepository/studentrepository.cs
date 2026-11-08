using ConsoleApp3.studentModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.studentRepository
{
    public class studentrepository
    {
        public void save(studentmodel s)
        {
            StreamWriter sr = new StreamWriter("file.txt",true);
            sr.WriteLine($"id is : {s.id}");
            sr.WriteLine($"name is : {s.name}");
            sr.WriteLine($"marks is : {s.marks}");
            sr.Close();
        }
    }
}
