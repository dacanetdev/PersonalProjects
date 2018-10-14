using System;
using System.Collections.Generic;

namespace SuperFizzBuzz
{
    /// <summary>
    /// Super fizz buzz generator. Outputs in Console FizzBuzz based on any combination
    /// of sequential range, custom values and token options for values.
    /// </summary>
    public class SuperFizzBuzzGenerator
    {
        private readonly IFizzBuzzTokenizer _fizzBuzzTokenizer;

        /// <summary>
        /// Gets or Sets sequential range start limit 
        /// </summary>
        /// <value>The start limit.</value>
        public int StartLimit { get; set; }

        /// <summary>
        /// Gets or Sets sequential range end limit
        /// </summary>
        /// <value>The end limit.</value>
        public int EndLimit { get; set; }

        /// <summary>
        /// Gets or sets the options of combination of value and token
        /// </summary>
        /// <value>The options.</value>
        public Dictionary<int,string> Options { get; set; }

        public SuperFizzBuzzGenerator(IFizzBuzzTokenizer fizzBuzzTokenizer)
        {
            _fizzBuzzTokenizer = fizzBuzzTokenizer;
        }

        /// <summary>
        /// Generates the classic FizzBuzz
        /// </summary>
        public void GenerateClassic()
        {
            StartLimit = 1;
            EndLimit = 100;

            RunFizzBuzz();
        }

        /// <summary>
        /// Generates the advanced FizzBuzz for any range of sequential values
        /// </summary>
        /// <param name="startLimit">Start limit.</param>
        /// <param name="endLimit">End limit.</param>
        public void GenerateAdvanced(int startLimit, int endLimit)
        {
            StartLimit = startLimit;
            EndLimit = endLimit;
            RunFizzBuzz();
        }

        /// <summary>
        /// Generates the advanced FizzBuzz for custom values
        /// For any supplied set of integers, even if they’re not sequential
        /// </summary>
        /// <param name="customValues">Custom values.</param>
        public void GenerateAdvanced(IEnumerable<int> customValues)
        {
            foreach (var value in customValues)
            {
                var result = GetFizzBuzzToken(value);
                Console.WriteLine(result);
            }
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

        /// <summary>
        /// Runs FizzBuzz loop incrementing when StartLimit is less than EndLimit
        /// </summary>
        private void RunNormal(){
            for (int value = StartLimit; value <= EndLimit; value++)
            {
                var result = GetFizzBuzzToken(value);
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Runs FizzBuzz loop decrementing when StartLimit is less than EndLimit
        /// </summary>
        private void RunInverse()
        {
            for (int value = StartLimit; value >= EndLimit; value--)
            {
                var result = GetFizzBuzzToken(value);
                Console.WriteLine(result);
            }
        }

        private string GetFizzBuzzToken(int value)
        {
            string result = string.Empty;
            if (Options == null)
            {
                result = _fizzBuzzTokenizer.GetToken(value);
            }
            else
            {
                result = _fizzBuzzTokenizer.GetToken(value, Options);
            }

            return result;
        }
    }
}
