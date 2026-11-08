using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class studentUI
    {
        studentService service = new studentService();

        public void Start()
        {
            studentModel s = new studentModel();

            Console.Write("Enter Name : ");
            s.name = Console.ReadLine();

            Console.Write("Enter Age : ");
            s.age = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks : ");
            s.marks = int.Parse(Console.ReadLine());

            service.AddStudent(s);
            service.CheckResult(s);
        }
    }
}
