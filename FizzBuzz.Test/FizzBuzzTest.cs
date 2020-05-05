using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        IFizzBuzzService fizzBuzzService = new FizzBuzzService();

        [TestMethod]
        public void IsFizz()
        {
            bool isFizz = fizzBuzzService.GetFizzOrBuzz(3) == fizzBuzzService.Fizz;
            Assert.IsTrue(isFizz); 
        }        
        
        [TestMethod]
        public void IsBuzz()
        {
            bool isBuzz = fizzBuzzService.GetFizzOrBuzz(5) == fizzBuzzService.Buzz;
            Assert.IsTrue(isBuzz); 
        }        

        [TestMethod]
        public void IsFizzBuzz()
        {
            bool isBuzz = fizzBuzzService.GetFizzOrBuzz(15) == fizzBuzzService.FizzBuzz;
            Assert.IsTrue(isBuzz); 
        }
    }
}
