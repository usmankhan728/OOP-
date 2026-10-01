namespace prictice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur a :");
            int a =int .Parse(Console.ReadLine());

            Console.WriteLine("enter ur b :");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter ur c :");
            int c = int.Parse(Console.ReadLine());

            if(a<=0 || b<=0 || c<=0)
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                double x1 = b + Math.Sqrt(b * b - 4 * a * c) / 2 * a;
                double x2 = b - Math.Sqrt(b * b - 4 * a * c) / 2 * a;

                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }

        }
    }
}
