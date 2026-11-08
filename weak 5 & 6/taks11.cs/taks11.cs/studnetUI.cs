using System;
using System.Collections.Generic;
using System.Text;

namespace taks11.cs
{
    internal class studnetUI
    {
        studentService service = new studentService();

        public void Start()
        {
            studentModel s = new studentModel();

            Console.Write("Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Marks: ");
            s.Marks = int.Parse(Console.ReadLine());

            service.AddStudent(s);
        }
    }
}
