namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { { 3, 4, 5 }, { 5, 3, 4 }, { 9, 5, 4 } };

            for(int row =0; row <= 2; row++)
               {
                for (int col = 0; col <= 2; col++)
                {
                    Console.Write(array[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
