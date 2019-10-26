using System;

namespace CS8_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new DefaultBot().Generate());
            Console.WriteLine(new FixedBot().Generate());
            Console.WriteLine(new DateTimeBot().Generate());
            Console.WriteLine(new GreetingBot().Generate());
        }
    }
}
