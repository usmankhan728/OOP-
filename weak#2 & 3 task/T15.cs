using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace task14.cs
{
    class student
    {
        public int id;
        public string name;
        public double gpa;

        public student()
        {

        }
        public student(int id,string name,double gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }
        public void display()
        {
            Console.WriteLine($"STUDENT ID IS {id}");
            Console.WriteLine($"STUDENT NAME IS {name}");
            Console.WriteLine($"STUDNET GPA IS {gpa}");
            Console.WriteLine();
        }

        public void update(double score)
        {
            gpa = score;
        }

        public void honorrole()
        {
            if(gpa >= 3.5)
            {
                Console.WriteLine($"student with high gpa is {name}");
            }
        }


    }
    internal class Program
    {
        static void checkstudent(List<student> students,int checkid)
        {
            bool found = false;
            foreach(student st in students)
            {
                if(st.id == checkid)
                {
                    st.display();
                    if(st.gpa >= 3.5)
                    {
                        Console.WriteLine($"{st.name} is a bright studnet");
                    }
                    else
                    {
                        Console.WriteLine("keep studying");
                    }
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("student info not found ");
            }
        }

        static void gradeupdation(List<student> students, double score,int id)
        {
            foreach(student st in students)
            {
                if(id == st.id)
                {
                   st.update(score); 
                }
            }
        }
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student(15, "ukay", 3.00);
            student s3 = new student(16, "astro", 2.7);
            student s4 = new student(10, "jack", 3.99);
            student s5 = new student(11, "jeemy", 3.3);

            List<student> students = new List<student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            //displaying student
            foreach(student st in students)
            {
                st.display();
            }

            Console.WriteLine("enter student id to check :");
            int checkid = int.Parse(Console.ReadLine());
            
            checkstudent(students, checkid);

            Console.WriteLine("enter student id for update scoring ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("update grade of student ");
            double score = double.Parse(Console.ReadLine());

            Console.WriteLine("score updated");
            gradeupdation(students, score, id);
            foreach (student st in students)
            {
                st.display();
            }



        }
    }
}
