using System;
using System.Collections.Generic;

namespace SuperFizzBuzz
{
    public interface IFizzBuzzTokenizer
    {
        /// <summary>
        /// Gets the token based on Classic FizzBuzz
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="value">Value.</param>
        string GetToken(int value);

        /// <summary>
        /// Gets the token for Advanced FizzBuzz
        /// using the Options parameter
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="value">Value.</param>
        /// <param name="options">Options Dictionary combination of value and token</param>
        string GetToken(int value, Dictionary<int, string> options);
    }
}
