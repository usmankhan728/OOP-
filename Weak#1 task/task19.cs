using System;
using System.IO;

namespace file__handlingprictice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three number :");
            int[] number = new int[3];
            for(int i=0; i<3; i++)
            {
                number[i] =  int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("array is : ");
            for(int i=0; i<3; i++)
            {
                Console.Write(number[i] + " ");
            }

            StreamReader sr = new StreamReader("data.txt");

            string? line;
            int sum = 0;
            while((line = sr.ReadLine()) != null)
            {
                int value = int.Parse(line);
                Console.WriteLine(line);
                sum = sum + value;
            }
            sr.Close();

        }
    }
}
