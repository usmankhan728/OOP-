using System.Globalization;

namespace task6.cs
{
    class employe
    {
        public String name;
        public int salary;
        public employe(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void asssignedproject(project p)
        {
            if(p.budget > salary)
            {
                Console.WriteLine("budget is high :");
            }
            else
            {
                Console.WriteLine("assigned successfully :");
            }
        }
        public int increasesalry(int amount)
        {
            salary = salary + amount;
            return salary;
        }
        public void displayemploye()
        {
            Console.WriteLine($"name = {name} and salary is {salary}");
        }
    }

    class project
    {
        public String name;
        public int budget;
        public project(String name, int budget)
        {
            this.name = name;
            this.budget = budget;
        }
        public void isaffordalbe(employe e)
        {
            if(e.salary > budget)
            {
                Console.WriteLine("project is affordable :");
            }
            else
            {
                Console.WriteLine("project is expensive :");
            }
        }
        public void displayproject()
        {
            Console.WriteLine($"name is {name} and budget is {budget} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 500;
            employe e = new employe("steve", 50000);
            e.displayemploye();
            project p = new project("dld", 40000);
            p.displayproject();
            p.isaffordalbe(e);
            e.asssignedproject(p);
        }
    }
}
