using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace test.cs
{
    class customer
    {
        public string name;
        public List<account> accounts;
       
        public customer(string name,List<account> accounts)
        {
            this.name = name;
            this.accounts = accounts;
        }
    }
    class account
    {
        public int id;
        public double balance;
        public account(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public double checkbalance() 
        { 
            return balance;
        }
        public void updatebalance()
        {
            
        }
    }
    internal class Program
    {
        satic void check(List<string> acc,string name)
        {
            for (int i = 0; i < List.count; i++)
            {
                if (acc[1] == name)
                {
                    Console.WriteLine("account found :");
                }
                else
                {
                    Console.WriteLine("account is not present :");
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> acc = new List<string>({ "steve", "tony", "bucky" });

                customer c1 = new customer("jemmy", acc);

                Console.WriteLine("1.CHECK ACCOUNTS :");
                Console.WriteLine("2.update balance :");
                Console.WriteLine("3.EXIT :");
                Console.WriteLine("\nenter ur choice :");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("enter account name u want to check");
                    string name = Console.ReadLine();
                    checked(List<string> acc,name);
                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter ur uodated balance :");
                    int bal = int.Parse(Console.ReadLine());

                }
                else if (choice == 3)
                {
                    break;
                }
                    
            }
            
        }
    }
}
