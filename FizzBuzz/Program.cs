using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();

            foreach (var result in fizzBuzzService.SimulateFizzBuzzGame(100))
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
