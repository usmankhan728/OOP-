using System;
namespace task17.cs
{
    public class player
    {
        public string name;
        public double health;
        public double power;
        public double score;

        public player(string name,double health, double power,double score)
        {
            this.name = name;
            this.health = health;
            this.power = power;
            this.score = score;
        }
        public void monsterattack(int demage)
        {
            health = health - (demage * 0.1);
            score = score - (demage * 0.3);

            Console.WriteLine(" health is " + health + ",,, score is " + score);
        }
        public void mineattack(int demage)
        {
            power = power - (demage * 0.1);
            health = health + (demage * 0.3);
            Console.WriteLine(" health is " + health + ",,,, power is " + power);
        }

        public void display()
        {
            Console.WriteLine($"player {name}");
            Console.WriteLine($"player health {health}");
            Console.WriteLine($"player power {power}");
            Console.WriteLine($"player score {score}");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            player p1 = new player("ukay", 100, 100, 100);
            p1.display();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1.monster attack");
                Console.WriteLine("2.mine attack");
                Console.WriteLine("3.exit attack");
                Console.WriteLine();
                Console.WriteLine("enter ur choice");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine("enter demage value under 100");
                    int demage = int.Parse(Console.ReadLine());
                    p1.monsterattack(demage);
                    

                }
                else if(choice == 2)
                {
                    Console.WriteLine("enter demage value under 100");
                    int demage = int.Parse(Console.ReadLine());
                    p1.mineattack(demage);
                }
                else if(choice == 3)
                {
                    break;
                }


            }
        }
    }
}
