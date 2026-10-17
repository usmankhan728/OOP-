namespace task7.cs
{
    internal class Program
    {
        class Student
        {
            private string name;
            private float matricMarks;
            private float fscMarks;
            private float ecatMarks;
            private float aggregate;

            public Student(string name, float matric, float fsc, float ecat)
            {
                this.name = name;
                matricMarks = matric;
                fscMarks = fsc;
                ecatMarks = ecat;
                aggregate = 0;
            }

            public void CalculateAggregate()
            {
                aggregate =
                (matricMarks / 1100f) * 30 +
                (fscMarks / 1100f) * 30 +
                (ecatMarks / 400f) * 40;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Matric: {matricMarks}");
                Console.WriteLine($"FSC: {fscMarks}");
                Console.WriteLine($"ECAT: {ecatMarks}");
                Console.WriteLine($"Aggregate: {aggregate:F2}");
                Console.WriteLine("----------------------");
            }

            public float GetAggregate()
            {
                return aggregate;
            }

            public string GetName()
            {
                return name;
            }
        }
        static Student AddStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Matric Marks: ");
            float matric = float.Parse(Console.ReadLine());

            Console.Write("Enter FSC Marks: ");
            float fsc = float.Parse(Console.ReadLine());

            Console.Write("Enter ECAT Marks: ");
            float ecat = float.Parse(Console.ReadLine());

            Student s = new Student(name, matric, fsc, ecat);

            return s; // returning object
        }

        static void ShowStudents(Student[] students, int count)
        {
            for (int i = 0; i < count; i++)
            {
                students[i].Display();
            }
        }

        static void CalculateAggregate(Student[] students, int count)
        {
            for (int i = 0; i < count; i++)
            {
                students[i].CalculateAggregate();
            }

            Console.WriteLine("Aggregates Calculated!");
        }

        static void TopStudents(Student[] students, int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (students[j].GetAggregate() >
                    students[i].GetAggregate())
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            int limit = count < 3 ? count : 3;

            Console.WriteLine("\nTop Students:");

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(
                $"{i + 1}. {students[i].GetName()} - {students[i].GetAggregate():F2}"
                );
            }
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            int count = 0;
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        students[count] = AddStudent();
                        count++;
                        break;

                    case 2:
                        ShowStudents(students, count);
                        break;

                    case 3:
                        CalculateAggregate(students, count);
                        break;

                    case 4:
                        TopStudents(students, count);
                        break;

                    case 5:
                        Console.WriteLine("Program Ended.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 5);
        }
    }
}
