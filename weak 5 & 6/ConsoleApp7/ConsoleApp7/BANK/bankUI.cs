using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.BANK
{
    internal class bankUI
    {
        public void start()
        {
            while (true)
            {
                Console.WriteLine("==========BANK ========");
                Console.WriteLine("1.CHECK balance :");
                Console.WriteLine("2.DEPOSITE money :");
                Console.WriteLine("3.WITHDRAW money :");
                Console.WriteLine("4.VIEW ALL data :");
                Console.WriteLine("5.EXIT :");

                Console.WriteLine("ENTER UR CHOICE :");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    
                }
                else if (choice == 2)
                {
                   
                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {

                }
                else if (choice == 5)
                {
                    break;
                }
            }

        }
    }
}
