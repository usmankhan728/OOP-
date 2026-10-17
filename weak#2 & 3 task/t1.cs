namespace task1.cs
{
    public class dog
    {
        public string name;
        public int age;

        public void bark()
        {
            Console.WriteLine($"{name} is barking");
        }
        public void eat(string food)
        {
            Console.WriteLine($"{name} is eating {food}");
        }
        public int convertage()
        {
            return age * 7;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dog mydog = new dog();
            mydog.name = "doggy";
            mydog.age = 3;

            mydog.bark();
            mydog.eat("dog food");

            int years = mydog.convertage();

            Console.WriteLine($"{mydog.name} age in human years is {years}");

            Console.ReadKey();
            
        }
    }
}
