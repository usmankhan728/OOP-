
using System.Globalization;
using System.Transactions;

namespace ConsoleApp1
{

    class Account
    {
        public string acc_title;
        public int acc_no;
        public double balance;
        public Account(string acc_title, int acc_no, double balance)
        {
            this.acc_title = acc_title;
            this.acc_no = acc_no;
            this.balance = balance;
        }

        public void display()
        {
            Console.WriteLine("ACCOUNT NUMBER : " + acc_no);
            Console.WriteLine("ACCOUNT TITLE : " + acc_title);
            Console.WriteLine("BALANCE = " + balance);
        }

        public void updateBallance(double amount)
        {
            if (balance + amount > 0)
            {
                balance += amount;
            }
            else
            {
                balance = balance;
            }
        }
    }

    class Customer
    {
        public string name;
        public List<Account> accounts;

        public Customer(string name)
        {
            this.name = name;
            accounts = new List<Account>();
        }

        public void AddAccount(Account acc)
        {
            accounts.Add(acc);
        }

        public void displayDetails()
        {
            Console.WriteLine("CUSTOMER NAME : " + name);
            Console.WriteLine();

            foreach (Account a in accounts)
            {
                a.display();
                Console.WriteLine();
            }
        }

        public double totalBalance()
        {
            double total = 0;
            foreach (Account a in accounts)
            {
                total += a.balance;
            }
            return total;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account A1 = new Account("save", 101, 1200);
            Account A2 = new Account("student ", 202, 1200);
            Account A3 = new Account("student ", 404, 1000);

            Customer C1 = new Customer("usman");
            Customer C2 = new Customer("nasir");

            C1.AddAccount(A1);
            C1.AddAccount(A3);
            C2.AddAccount(A2);
            A1.updateBallance(1000);
            C2.totalBalance();
            double total = C1.totalBalance();
            Console.WriteLine(total);
            C1.displayDetails();
        }
    }
}