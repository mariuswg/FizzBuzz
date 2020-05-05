using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IList<string> GetFizzBuzz(int count)
        {
            IList<string> values = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                values.Add(GetFizzOrBuzz(i));
            }
            return values;
        }

        public string GetFizzOrBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}