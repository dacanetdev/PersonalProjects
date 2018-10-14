using System;
using System.Collections.Generic;

namespace SuperFizzBuzz
{
    public interface IFizzBuzzTokenizer
    {
        string Execute(int value);

        string Execute(int value, Dictionary<int, string> options);
    }
}
