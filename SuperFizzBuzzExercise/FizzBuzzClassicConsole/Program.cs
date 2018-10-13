using System;
using SuperFizzBuzz;

namespace FizzBuzzClassicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(new FizzBuzzTokenizer());

            superFizzBuzzGenerator.GenerateClassic();

            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }
    }
}
