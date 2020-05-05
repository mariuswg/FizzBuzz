using System.Collections.Generic;

namespace FizzBuzz
{
    public interface IFizzBuzzService
    {
        string Fizz { get; }
        string Buzz { get; }
        string FizzBuzz { get; }

        IList<string> GetFizzBuzz(int count);
        string GetFizzOrBuzz(int number);
    }
}