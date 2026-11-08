using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp3.studentModel;
using ConsoleApp3.studentService;
namespace ConsoleApp3.studentUI
{
    public class StudentUI
    {
        studentservice service = new studentservice();
        studentmodel s = new studentmodel();
        public void menu()
        {
            while (true)
            {
                Console.WriteLine("1.ADD STUDENT");
                Console.WriteLine("2.SHOW STUDENT");
                Console.WriteLine("3.CHECK RESULT");
                Console.WriteLine("4.EXIT");

                Console.Write("ENTER UR CHOICE :");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine("ENTER UR ID");
                    s.id = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER UR NAME");
                    s.name = Console.ReadLine();
                    Console.WriteLine("ENTER UR MARKS");
                    s.marks = int.Parse(Console.ReadLine());

                    service.addstudent(s);
                }
                else if(choice == 2)
                {
                    service.show(s);
                }
                else if (choice == 3)
                {
                    service.checkresult(s);
                }
                else if (choice == 4)
                {
                    break;
                }

            }
        }
    }
}
