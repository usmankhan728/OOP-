namespace ConsoleApp10
{
    internal class Program
    {
       static void printing(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 3, 4, 6, 7 };

            printing(array);

        }
    }
}
