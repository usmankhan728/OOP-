namespace prictice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           for(int i=0; i < 10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
