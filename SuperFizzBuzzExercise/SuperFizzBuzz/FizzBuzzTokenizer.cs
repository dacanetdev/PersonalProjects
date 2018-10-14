using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFizzBuzz
{
    public class FizzBuzzTokenizer: IFizzBuzzTokenizer
    {
        public FizzBuzzTokenizer()
        {
        }

        //Overload for Classic FizzBuzz
        public string Execute(int value){
            var options = new Dictionary<int, string>{
                {3, "Fizz"},
                {5, "Buzz"}
            };

            return Execute(value, options);
        }

        //Overload for Advanced FizzBuzz
        public string Execute(int value, Dictionary<int, string> options)
        {
            var sbResult = new StringBuilder();

            foreach (var option in options)
            {
                if(value % option.Key == 0){
                    sbResult.Append(option.Value);
                }
            }

            var result = sbResult.ToString();

            return !string.IsNullOrWhiteSpace(result) ? result : value.ToString();
        }
    }
}
