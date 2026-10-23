using System;
namespace task1.cs
{
    public class student
    {
        public string name;
        public int age;
        public student (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine($"student is {name}\n : and his/her age is {age}");
        }
    }

    class school
    {
        public void showStudent(student one)
        {
           one.display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student one = new student("ukay", 19);
            school data = new school();
            data.showStudent(one);
            
        }
    }
}
