namespace prictice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int average;
            for(int i=0; i<5; i++)
            {
                int value = int.Parse(Console.ReadLine());
                sum = sum + value;
                
            }

            average = sum / 5;
            Console.WriteLine("AVERAGE IS :{0}" , average);
            Console.WriteLine(sum);
        }
    }
}
