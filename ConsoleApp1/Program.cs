using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
        
            Console.WriteLine("Say your name");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"/nHello, {name} on {date:d} at {date:t}");
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey(true);
        }
    }
}
