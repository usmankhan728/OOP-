namespace task3
{
    class Calculator
    {
        // Constructor
        public Calculator()
        {
            Console.WriteLine("Calculator Created!");
        }

        // Addition method
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtraction method
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiplication method
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Division method
        public double Divide(int a, int b)
        {
            return (double)a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

           
            Console.WriteLine("Addition: " + calc.Add(10, 5));
            Console.WriteLine("Subtraction: " + calc.Subtract(10, 5));
            Console.WriteLine("Multiplication: " + calc.Multiply(10, 5));
            Console.WriteLine("Division: " + calc.Divide(10, 5));

            Console.ReadKey();
        }
    }
}
