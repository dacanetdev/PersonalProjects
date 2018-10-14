using System;
using System.Collections.Generic;
using SuperFizzBuzz;

namespace FizzBuzzAdvancedConsole
{
    class Program
    {
        static void Main()
        {
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(new FizzBuzzTokenizer()) {
                Options = new Dictionary<int, string> {
                    {3, "Fizz"},
                    {7, "Buzz"},
                    {38, "Bazz"}
                }
            };

            superFizzBuzzGenerator.GenerateAdvanced(-12, 145);

            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }
    }
}
