using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.EXPENCES
{
    internal class expenceUI
    {
        expenceService service = new expenceService();
        public void menu(List<expenceModel> data, expenceModel e)
        {

            Console.Write("ENTER TITLE :");
            e.title = Console.ReadLine();
            Console.Write("ENTER AMOUNT ($) :");
            e.amount = int.Parse(Console.ReadLine());

            data.Add(e);

        }
        public void start()
        {
            List<expenceModel> data = new List<expenceModel>();
            
            while(true)
            {
                Console.WriteLine("1.ADD EXPENCES TO THE FILE:");
                Console.WriteLine("2.VIEW ALL EXPENCES FROM FILE :");
                Console.WriteLine("3.EXIT :");

                Console.WriteLine("Enter ur choice :");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    expenceModel e = new expenceModel();
                    menu(data,e);
                    service.add(e);
                    Console.WriteLine("ADDED successfully !");
                }
                else if(choice == 2)
                {
                    List<expenceModel> expenses = service.view();

                    Console.WriteLine("\n--- SAVED EXPENSES ---");
                    foreach (var item in expenses)
                    {
                        Console.WriteLine($"Title: {item.title}, Amount: {item.amount}");
                    }
                }
                else if( choice == 3)
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}
