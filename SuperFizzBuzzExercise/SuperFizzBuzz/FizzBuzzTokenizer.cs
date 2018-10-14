using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFizzBuzz
{
    /// <summary>
    /// Fizz buzz tokenizer. Returns FizzBuzz Tokens based on value
    /// * If only value is provided Executes Classic FizzBuzz: 
    ///     1 to 100, multiples of 3 = Fizz, multiples of 5 = Buzz,
    /// multiples of 3 and 5 = FizzBuzz
    /// * If options are provided it can return any token for any
    /// value specified in the Options Dictionary
    /// </summary>
    public class FizzBuzzTokenizer: IFizzBuzzTokenizer
    {
        //Overload for Classic FizzBuzz
        public string GetToken(int value){
            var options = new Dictionary<int, string>{
                {3, "Fizz"},
                {5, "Buzz"}
            };

            return GetToken(value, options);
        }

        //Overload for Advanced FizzBuzz
        public string GetToken(int value, Dictionary<int, string> options)
        {
            if (value == 0) return "0";

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
