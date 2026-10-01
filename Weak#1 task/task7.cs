namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("press any key to continue OR 5 to cancel");
            int key = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                
                if (key == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("enter ur score :");
                    int score = int.Parse(Console.ReadLine());
                    if (score > 33)
                    {
                        Console.WriteLine("pass");
                    }
                    else
                    {
                        Console.WriteLine("fail");
                    }
                }

            }
            
            
            
        }
    }
}
