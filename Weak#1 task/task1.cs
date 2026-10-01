namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("enter ur score :");
                int score = Convert.ToInt32(Console.ReadLine());

                if (score > 33)
                {
                    Console.WriteLine("passed");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            

        }
    }
}
