namespace task20.cs
{
    class calculator
    {
        public int num1;
        public int num2;

        public calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int add()
        {
            return num1 + num2;
        }
        public int subtract()
        {
            return num1 - num2;
        }
        public int multyply()
        {
            return num1 * num2;
        }
        public int divide()
        {
            return num1 / num2;
        }
        public int modulo()
        {
            return num1 % num2;
        }
        public void display()
        {
            Console.WriteLine($"THE RESULT OFADDITION : {num1} AND {num2} IS {add()}");
            Console.WriteLine($"THE RESULT OF SUBTARCTION : {num1} AND {num2} IS {subtract()}");
            Console.WriteLine($"THE RESULT OF MULTIPICATION : {num1} AND {num2} IS {multyply()}");
            Console.WriteLine($"THE RESULT OF DIDVISION : {num1} AND {num2} IS {divide()}");
            Console.WriteLine($"THE RESULT OF MODULO : {num1} AND {num2} IS {modulo()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator oper = new calculator(5, 5);
            oper.display();

        }
    }
}
