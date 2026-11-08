using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ConsoleApp2
{
    internal class studentRepository
    {
       public void SaveStudent(studentModel s)
        {
            StreamWriter sw = new StreamWriter("student.txt", true);

            sw.WriteLine("Name : " + s.name);
            sw.WriteLine("Age : " + s.age);
            sw.WriteLine("Marks : " + s.marks);
            sw.WriteLine("----------------");

            sw.Close();
        }
    }
}
