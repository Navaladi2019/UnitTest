using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Business.Tests
{
    /*
     * If divisible by 3       -> return "Fizz"
     * If divisible by 5       -> return "Buzz"
     * If divisible by 3 and 5 -> return "FizzBuzz"
     * Otherwise               -> return "" 
     */
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 6)]
        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 10)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("", 7)]
        public void TestFizzBuzz(string expected, int number)
        {
            Assert.AreEqual(expected, FizzBuzz.Ask(number));
        }
    }
}
