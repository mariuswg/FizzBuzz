using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        /// <summary>
        /// String representations of the possible outcomes
        /// </summary>
        public string Fizz { get; } = "Fizz";
        public string Buzz { get; } = "Buzz";
        public string FizzBuzz { get; } = "FizzBuzz";

        /// <summary>
        /// Simulate the FizzBuzz math game for a given number of integers, starting at 1
        /// </summary>
        /// <param name="count">The number at which the game will end</param>
        /// <returns>The resulting string of the FizzBuzz game simulation</returns>
        public IList<string> GetFizzBuzz(int count)
        {
            IList<string> values = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                values.Add(GetFizzOrBuzz(i));
            }
            return values;
        }

        /// <summary>
        /// Get the fizzbuzz value of the number or return the number
        /// </summary>
        /// <param name="number">Integer to convert to a FizzBuzz value</param>
        /// <returns>FizzBuzz string value, or the input integer as a string</returns>
        public string GetFizzOrBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return FizzBuzz;
            }
            else if (number % 3 == 0)
            {
                return Fizz;
            }
            else if (number % 5 == 0)
            {
                return Buzz;
            }
            else
            {
                return number.ToString();
            }
        }
    }
}