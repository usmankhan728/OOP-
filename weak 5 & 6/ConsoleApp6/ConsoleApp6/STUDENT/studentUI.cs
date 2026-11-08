using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.STUDENT
{
    internal class studentUI
    {
        studentService service = new studentService();
        public void start()
        {
            while (true)
            {
                Console.WriteLine("1.ADD STUDENT ");
                Console.WriteLine("2.CHECK student by id :");
                Console.WriteLine("3.SHOW STUDENT DETAIL ");
                Console.WriteLine("4.EXIT ");

                Console.Write("ENTER UR CHOICE :");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.Clear();
                    studentModel s = addstudent();
                    service.add(s);
                    Console.WriteLine("student added successfully :");
                    Console.ReadKey();
                }
                else if(choice == 2)
                {
                    Console.Clear();
                    Console.Write("ENTER ur id :");
                    int cid = int.Parse(Console.ReadLine());

                    List<studentModel> records = service.data();
                    var result = service.check(cid, records);

                    if (result == true)
                    {
                        Console.WriteLine("student found");
                    }
                    else if(result == false)
                    {
                        Console.WriteLine("student not found :");
                    }



                }
                else if (choice == 3)
                {
                    List<studentModel> redords =  service.data();
                    Console.WriteLine("===record===");
                    foreach (studentModel s in redords) 
                    {
                        Console.WriteLine(s);
                    }
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid INPUT :");
                    break;
                }
            }
        }
        public studentModel addstudent()
        {
            Console.Write("ENTER ur id :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("ENTER ur name :");
            string name = Console.ReadLine();
            Console.Write("ENTER UR fee :");
            double fee = double.Parse(Console.ReadLine());

            studentModel s = new studentModel(id,name,fee);
            return s;
        }
    }
}
