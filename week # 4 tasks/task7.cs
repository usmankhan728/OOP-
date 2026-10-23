using System.Data.SqlTypes;
using System.Globalization;
using System.Security.Cryptography;

namespace task7.cs
{
    class student
    {
        public string name;
        public int age;
        public double fsc;
        public double ecat;
        public double merit;
        public List<degree> preferences;
        public List<subject> regsubjects;
        public degree regdegree;
        public student(String name,int age,double fsc,double ecat)
        {
            this.name = name;
            this.age = age;
            this.fsc = fsc;
            this.ecat = ecat;
            preferences = new List<degree>();
        }
        public void calculateMerit()
        {

        }
        public int getCH()
        {

        }
        public float calaculateFee()
        {

        }
        public void regStudentSubject(subject s) { 
        }

    }
    class degree
    {
        public string title;
        public int duration;
        public int seat;
        public degree(String title,int duration,int seat)
        {
            this.title = title;
            this.duration = duration;
            this.seat = seat;
        }
        public bool issubjectEXISTS(subject s)
        {

        }
        public void addsubject(subject s)
        {

        }
        public int calculateCH()
        {

        }

    }
    class subject
    {
        public string code;
        public int ch;
        public string subjecttype;
        public int subjectFEE;
        public subject(string code,int ch,string subjecttype,int subjectFEE)
        {
            this.code = code;
            this.ch = ch;
            this.subjecttype = subjecttype;
            this.subjectFEE = subjectFEE;
        }


    }
    internal class Program
    {
        static student inputSTU(student students)
        {
            Console.WriteLine("enter name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter fsc marks :");
            int fsc = int.Parse(Console.ReadLine());
            Console.WriteLine("enter ecat marks :");
            int ecat = int.Parse(Console.ReadLine());
            Console.WriteLine("enter preferences (3)");
            
            student s = new student(name, age, fsc, ecat);
            return s;

        }
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            List<subject> sub = new List<subject>();
            List<degree> deg = new List<degree>();

            while (true)
            {
                Console.WriteLine("1.ADD STUDENT");
                Console.WriteLine("2.ADD DEGREE PROGRAM");
                Console.WriteLine("3.GENERATE MERIT");
                Console.WriteLine("4.VIEW REGESTERED STUDENT");
                Console.WriteLine("5.VIEW STUDENT OF SPECIFIC PROGRAM");
                Console.WriteLine("6.REGESTER SUBJECTS FOR A SPECIFIC STUDENT");
                Console.WriteLine("7.CALCULATE FEE FOR ALL REGESTER STUDENT");
                Console.WriteLine("8.EXIT");
                Console.WriteLine("\nenter ur choics");
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
                else if(choice == 4)
                {

                }
                else if(choice == 5)
                {

                }
                else if(choice == 6)
                {

                }
                else if(choice == 7)
                {

                }
                else if(choice == 8)
                {
                    break;
                }

            }
        }
    }
}