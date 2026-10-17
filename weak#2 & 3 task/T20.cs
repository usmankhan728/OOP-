namespace task19.cs
{
    class typeclock
    {
        public int hour;
        public int minute;
        public int second;

        public typeclock()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public typeclock(int h)
        {
            hour = h;
        }
        public typeclock(int h,int m)
        {
            hour = h;
            minute = m;
        }
        public typeclock(int h, int m,int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public void inceementsec()
        {
            second++;
        }
        public void inceementmin()
        {
            minute++;
        }
        public void inceementhr()
        {
           hour++;
        }
        public void print()
        {
            Console.WriteLine(hour + " : " + minute + " : " + second);
        }
        public bool isequal(typeclock temp )
        {
            if(hour == temp.hour && minute == temp.minute && second == temp.second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            typeclock empty = new typeclock();
            Console.WriteLine("empty time : ");
            empty.print();

            typeclock one = new typeclock(8);
            Console.WriteLine("hour time :");
            one.print();

            typeclock two = new typeclock(8,10);
            Console.WriteLine("minute time :");
            two.print();

            typeclock three = new typeclock(8,10,6);
            Console.WriteLine("full time :");
            three.print();

            three.inceementsec();
            Console.WriteLine("full time(increement second) :");
            three.print();

            three.inceementmin();
            Console.WriteLine("full time(increment minute) :");
            three.print();

            three.inceementhr();
            Console.WriteLine("full time(increment hour) :");
            three.print();
        }
    }
}
