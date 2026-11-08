using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class studentService
    {
        studentRepository repo = new studentRepository();

        public void AddStudent(studentModel s)
        {
            repo.SaveStudent(s);

            Console.WriteLine("Student Saved");
        }

        public void CheckResult(studentModel s)
        {
            if (s.marks >= 40)
            {
                Console.WriteLine("Result : Pass");
            }
            else
            {
                Console.WriteLine("Result : Fail");
            }
        }

    }
}
