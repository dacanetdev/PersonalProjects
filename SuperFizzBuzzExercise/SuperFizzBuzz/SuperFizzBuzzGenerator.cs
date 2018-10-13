using System;

namespace SuperFizzBuzz
{
    public class SuperFizzBuzzGenerator
    {
        private IFizzBuzzTokenizer _fizzBuzzTokenizer;


        public int StartLimit
        {
            get;
            set;
        }

        public int EndLimit
        {
            get;
            set;
        }

        public SuperFizzBuzzGenerator(IFizzBuzzTokenizer fizzBuzzTokenizer)
        {
            _fizzBuzzTokenizer = fizzBuzzTokenizer;
        }

        public void GenerateClassic()
        {
            StartLimit = 1;
            EndLimit = 100;

            for (int value = StartLimit; value <= EndLimit; value++)
            {
                var result = _fizzBuzzTokenizer.Execute(value);
                Console.WriteLine(result);
            }
        }
    }
}
