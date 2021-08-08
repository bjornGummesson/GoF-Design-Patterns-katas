using System;

namespace AbstractFactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FactoryProducer.GetFactory(true).GetShape("square").draw();
            FactoryProducer.GetFactory(false).GetShape("rectangle").draw();
        }
    }
}
