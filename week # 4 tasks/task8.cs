using System.Globalization;

namespace task8.cs
{
    class student
    {
        public string Sname;
        public List<subject> subjects = new List<subject>();
        public student(string Sname)
        {
            this.Sname = Sname;
            subjects = new List<subject>();
        }
        public void addsub(subject s)
        {
            subjects.Add(s);
        }
        public void displaySUB()
        {
            Console.WriteLine("student : " + Sname);
            foreach (subject x in subjects)
            {
                Console.WriteLine("subject : "+ x.name + " marks : "+ x.marks );
            }
        }
    }
class subject
{
    public string name;
    public int marks;
    public subject(string name, int marks)
    {
       this. name = name;
       this. marks = marks;
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>(); 
            student stu1 = new student("ukay");
            students.Add(stu1);
            student stu2 = new student("steve");
            students.Add(stu2);
            student stu3 = new student("jemmy");
            students.Add(stu3);

            subject s1 = new subject("OOP", 94);
            subject s2 = new subject("DB", 95);
            subject s3 = new subject("DLD", 96);

            stu1.addsub(s1);
            stu1.addsub(s2);
            stu1.addsub(s3);
            stu2.addsub(s1);
            stu2.addsub(s2);
            stu2.addsub(s3);
            stu3.addsub(s1);
            stu3.addsub(s2);
            stu3.addsub(s3);

            stu1.displaySUB();
            stu2.displaySUB();
            stu3.displaySUB();





        }
    }
}
