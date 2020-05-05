using System.Collections.Generic;

namespace FizzBuzz
{
    /// <summary>
    /// A FizzBuzz math game service
    /// </summary>
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
        /// FizzBuzz Rules: 
        /// If number is dividable by 3, say "Fizz". 
        /// If dividable by 5, say "Buzz". 
        /// If dividable by 15, say "FizzBuzz".
        /// If a person says the number instead of the FizzBuzz value, that person is out of the game.
        /// </summary>
        /// <param name="count">The number at which the game will end</param>
        /// <returns>The resulting string of the FizzBuzz game simulation</returns>
        public IList<string> SimulateFizzBuzzGame(int count)
        {
            IList<string> values = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                values.Add(GetFizzOrBuzz(i));
            }
            return values;
        }

        /// <summary>
        /// Get the FizzBuzz value of the given number based on the rules of the game
        /// </summary>
        /// <param name="number">Integer to convert to a FizzBuzz value</param>
        /// <returns>FizzBuzz value, or integer as a string</returns>
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