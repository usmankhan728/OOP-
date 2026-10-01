namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter city one temprature :");
            int temp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second temprature :");
            int temp2 = Convert.ToInt32(Console.ReadLine());
            if(temp1-temp2 > 10)
            {
                Console.WriteLine("difference is too big .");
            }
            else
            {
                Console.WriteLine("wow nice....");
            }
        }
    }
}
