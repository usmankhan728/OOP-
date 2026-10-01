namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            while (value <= 10)
            {
                if(value%2 == 0)
                {
                   System.Console.WriteLine("value is {0}",value);
                }
                value++;
            }

        }
    }
}
