using System.Security.Cryptography.X509Certificates;

namespace task2.cs
{
    class account
    {
        public string OwnerName;
        public int balance;
        public account(string ownerName, int balance)
        {
            this.OwnerName = ownerName;
            this.balance = 10000;
        }
        public double deposite(int value)
        {
            balance = balance + value;
            return balance;
        }
        public  double getbalance()
        {
            return balance;
        }
        public void display()
        {
            Console.WriteLine($"{OwnerName} balance is {balance}");
        }
    }
    class bank
    {
        public void showACC(account one)
        {
            Console.WriteLine($"{one.OwnerName} balance is {one.getbalance()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account one = new account("ukay",500);
            one.display();
            Console.WriteLine();
            Console.WriteLine("enter deposite amount :");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("after deposite : " + one.deposite(value));
            Console.WriteLine();
            bank two = new bank();
            two.showACC(one);


        }
    }
}
