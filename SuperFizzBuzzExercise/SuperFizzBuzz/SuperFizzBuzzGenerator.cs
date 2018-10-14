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

            RunFizzBuzz();
        }

        public void GenerateAdvanced(int startLimit, int endLimit)
        {
            StartLimit = startLimit;
            EndLimit = endLimit;
            RunFizzBuzz();
        }

        private void RunFizzBuzz()
        {
            if(StartLimit <= EndLimit)
            {
                RunNormal();
            }
            else
            {
                RunInverse();
            }

        }

        private void RunNormal(){
            for (int value = StartLimit; value <= EndLimit; value++)
            {
                var result = _fizzBuzzTokenizer.Execute(value);

                Console.WriteLine(result);
            }
        }

        private void RunInverse()
        {
            for (int value = StartLimit; value >= EndLimit; value--)
            {
                var result = _fizzBuzzTokenizer.Execute(value);

                Console.WriteLine(result);
            }
        }
    }
}
