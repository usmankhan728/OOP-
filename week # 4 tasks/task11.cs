using System.Globalization;

namespace task10.cs
{
    class account
    {
        public int number;
        public int balance;
        public account(int  number, int balance)
        {
            this.number = number;
            this.balance= balance;
        }
        public void deposite(customer c,int money,account a)
        {
            int result = c.depositemoney(money, a);
            Console.WriteLine($"NOW YOYR CURRRENT BALANCE IS : {result}");
        }
        public void withdraw(customer c, int WD, account a)
        {
            int result = c.depositemoney(WD, a);
            Console.WriteLine($"NOW YOYR CURRRENT BALANCE IS : {result}");
        }

    }
    class ATM
    {
        public string location;
        public ATM(string location)
        {
            this.location = location;
        }
        public bool conforms(int number,account a)
        {
           if(number == a.number)
            {
                Console.WriteLine("autentication conformed :");
                return true;
            }
            Console.WriteLine("sorry account not found :");
            return false;
        }
        public void display()
        {
            Console.WriteLine("1.check balance :");
            Console.WriteLine("2.deposite money :");
            Console.WriteLine("3.withdraw money :");
        }

    }
    class customer
    {
        public string name;
        public account Baccount;
        public customer(string name)
        {
            this.name = name;
        }
        public void checkbalance(account a)
        {
            Console.WriteLine($"YOUR BALANCE IS : {a.balance}");

        }
        public int depositemoney(int money,account a)
        {
            a.balance = a.balance + money;
            return a.balance;
        }
        public int withdrawmoney(int WD,account a)
        {
            a.balance = a.balance + WD;
            return a.balance;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account a = new account(101, 100000);

            Console.WriteLine("ENTER UR NAME :");
            string NAME = Console.ReadLine();

            customer c = new customer(NAME);

            Console.WriteLine("ENTER ACCOUNT NUMBER :");
            int number = int.Parse(Console.ReadLine());

            ATM one = new ATM("uet atm");

            bool result = one.conforms(number, a);


            if (result)
            {
                one.display();
                Console.WriteLine("ENTER UR CHOICE :");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    c.checkbalance(a);
                }
                else if(choice == 2)
                {
                    Console.WriteLine("ENTER DEPOSITE AMMOUNT :");
                    int money = int.Parse(Console.ReadLine());

                    c.depositemoney(money, a);
                    a.deposite(c, money, a);

                }
                else if( choice == 3)
                {
                    Console.WriteLine("ENTER WITHDRAW AMMOUNT :");
                    int WD = int.Parse(Console.ReadLine());

                    c.withdrawmoney(WD, a);
                    a.deposite(c, WD, a);
                }
                else
                {
                    Console.WriteLine("invalid option :");
                }
            }



            Console.ReadKey();
            


            


             
        }
    }
}
