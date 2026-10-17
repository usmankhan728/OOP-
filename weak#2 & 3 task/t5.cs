using System.Runtime.CompilerServices;

namespace task5.cs
{
    public class atm
    {
        public int balance;
        public atm(int current)
        {
            this.balance = current;
        }

        public void deposite(int current)
        {
            balance += current;
         
            
        }
        public void withdraw(int current)
        {
            balance -= current;
           
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            atm bank = new atm(100000);

            Console.WriteLine("ur current balnce is {0}", bank.balance);
            
            Console.WriteLine("enter 1 for deposite ....or 2 for withdraw :");
            int choice = int.Parse(Console.ReadLine());
            if(choice  == 1)
            {
                Console.WriteLine("enter amount :");
                int amount = int.Parse(Console.ReadLine());
                
                Console.WriteLine("ur deposited amount = {0}", amount);
                bank.deposite(amount);
                Console.WriteLine("now ur bank balance is {0}", bank.balance);
            }
            else if (choice == 2)
            {
                Console.WriteLine("enter amount :");
                int amount = int.Parse(Console.ReadLine());
                
                Console.WriteLine("ur withdrawed amount = {0}", amount);
                bank.withdraw(amount);
                Console.WriteLine("now ur bank balance is {0}", bank.balance);
            }

        }
    }
}
