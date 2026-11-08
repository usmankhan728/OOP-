using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class engine
    {
        public string type;
        public engine(string type)
        {
            this.type = type;
            
        }
    }

    public class car
    {
        public engine engine;
        public car(engine engine)
        {
            this.engine = engine;
        }
        public void crush()
        {
            Console.WriteLine("car crushed ; including the engine {0}", engine.type);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            engine engine = new engine("V8");
            car car = new car(engine);
            car.crush();
        }
    }
}
