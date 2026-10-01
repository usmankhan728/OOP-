namespace prictice4
{
    internal class Program
    {
        static void order(char[] array)
        {
            Array.Sort(array);
            foreach(char c in array)
            {
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            char[] array = new char[5] { 'z', 'c', 'd', 'b', 'e' };
            order(array);

        }
    }
}
