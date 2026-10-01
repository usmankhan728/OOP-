namespace filehandling_prictice6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur string :");
            string name = Console.ReadLine();

            for(int i=0; i<name.Length; i++)
            {
                bool duplicate = false;
                for(int j=i+1; j<name.Length; j++)
                {
                    if (name[i] == name[j])
                    {
                        duplicate = true;
                        break;
                    }  
                }
                if (duplicate == false)
                {
                    Console.Write(name[i] + " ");
                }
            }
        }
    }
}
