using System;
using System.Globalization;


namespace task13.cs
{
    class bankaccount
    {
        public int number;
        public string name;
        public double balance;
        public bankaccount(int number,String name,double balance)
        {
            this.number = number;
            this.name = name;
            this.balance = balance;
        }

        public double currentbalance()
        {
            return balance;
        }

        public double deposite()
        {
            Console.WriteLine("ENTER DEPOSITE EMOUNT :");
            double amount = double.Parse(Console.ReadLine());
            double result = balance + amount;
            return result;
             
        }
        public double withdraw()
        {
            Console.WriteLine("ENTER withdraw EMOUNT :");
            double amount = double.Parse(Console.ReadLine());
            double result = balance - amount;
            return result;
        }

        /*public void show()
        {
            Console.WriteLine($"account number is {number}");
            Console.WriteLine($"account name is {name}");
            Console.WriteLine($"account balance is {balance}");
        }*/

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<bankaccount> accounts = new List<bankaccount>();
            int choice;
            do
            {
                Console.WriteLine("1.OPEN NEW ACCOUNT :");
                Console.WriteLine("2.DO TRANSACTIONS :");
                Console.WriteLine("3.SHOW ALL ACCOUNTS DETAIAL :");
                Console.WriteLine("4.EXIT :");
                Console.WriteLine("==============================");
                Console.WriteLine("ENTER UR OPTION :");
                choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine("ENTER ACCOUNT NUMBER :");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine("ENTER ACCOUNT NAME :");
                    string name = Console.ReadLine();
                    Console.WriteLine("ENTER ACCOUNT BALANCE :");
                    double balance = double.Parse(Console.ReadLine());

                    bankaccount one = new bankaccount(number, name, balance);
                    accounts.Add(one);

                }
                else if(choice == 2)
                {

                }
                else if(choice == 3)
                {
                    foreach(bankaccount bankaccount in accounts)
                    {
                        Console.WriteLine($"account number is {bankaccount.number}");
                        Console.WriteLine($"account name is {bankaccount.name}");
                        Console.WriteLine($"account balance is {bankaccount.balance}");
                        Console.WriteLine("=================");
                    }
                }
                else if(choice == 4)
                {
                    break;
                }


            } while (choice != 4);
            
        }
    }
}
