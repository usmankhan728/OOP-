namespace tsak
{
    internal class Program
    {
        static void showtemp(int[] temp)
        {
            for(int i=0; i<temp.Length; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.WriteLine();
        }
        static void counthot(int[] temp)
        {
            for(int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > 30)
                {
                    Console.WriteLine("hot temp is " + temp[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] temp = new int[4] { 19, 45, 33, 29 };
            showtemp(temp);
            counthot(temp);

        }
    }
}
