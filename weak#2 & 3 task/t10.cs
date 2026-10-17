namespace task9.cs
{
    class rectangle
    {
        public int length;
        public int width;
        public rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public double area()
        {
           return length * width;
        }
        public double perimeter()
        {
            return (length * width)/2;
        }
        public void display()
        {
            Console.WriteLine($"length is = {length}");
            Console.WriteLine($"width is = {width}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            rectangle data = new rectangle(4,5);
            data.display();
            double result = data.area();
            Console.WriteLine("area is " + result);

            
        }
    }
}
