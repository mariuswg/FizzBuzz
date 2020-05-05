using System.Collections.Generic;

namespace FizzBuzz
{
    public interface IFizzBuzzService
    {
        IList<string> GetFizzBuzz(int count);
        string GetFizzOrBuzz(int number);
    }
}