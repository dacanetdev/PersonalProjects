using System;
namespace SuperFizzBuzz
{
    public class FizzBuzzTokenizer: IFizzBuzzTokenizer
    {
        public FizzBuzzTokenizer()
        {
        }

        public string Execute(int value){
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (value % 3 == 0)
            {
                return "Fizz";
            }

            if(value % 5 == 0)
            {
                return "Buzz";
            }

            return value.ToString();
        }
    }
}
