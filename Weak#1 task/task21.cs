namespace filehandling_prictice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("file.txt");

            int vowel = 0;
            int consonent = 0;

            Console.WriteLine("enter ur string");
            string word = Console.ReadLine();

            for(int i = 0;i <word.Length; i++)
            {
                if (word[i] =='a' || word[i] == 'e' || word[i] == 'i' || word[i] == '0' || word[i] == 'u')
                {

                    vowel++;
                }
                else
                {
                    
                    consonent++;
                }
                
            }
            sw.WriteLine("vowel = " + vowel);
            sw.WriteLine("consonent = " + consonent);
            sw.Close();

            Console.WriteLine("vowels are : " + vowel);
            Console.WriteLine("consonent are " + consonent);

            StreamReader sr = new StreamReader("file.txt");

            string line;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
            

        }
    }
}
