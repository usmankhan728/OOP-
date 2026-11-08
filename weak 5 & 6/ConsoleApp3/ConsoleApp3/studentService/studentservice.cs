using ConsoleApp3.studentModel;
using ConsoleApp3.studentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.studentService
{
    public class studentservice
    {
        studentrepository repo = new studentrepository();

        public void addstudent(studentmodel s)
        {
            repo.save(s);
            Console.WriteLine("saved successfully !");
        }
        public void show(studentmodel s)
        {
            Console.WriteLine($"id is : {s.id}");
            Console.WriteLine($"name is : {s.name}");
            Console.WriteLine($"marks is : {s.marks}");
        }
        public void checkresult(studentmodel s)
        {
            if(s.marks > 33)
            {
                Console.WriteLine("passes :");
            }
            else
            {
                Console.WriteLine("failed :");
            }
        }
    }
}
