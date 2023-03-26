using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        [TestCase (15, "FizzBuzz")]
        [TestCase (6, "Fizz")]
        [TestCase (10, "Buzz")]
        [TestCase (2, "2")]
        public void GetOutput_IntegerDivisibleByThreeAndFive_ReturnAppropriateString(int input, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}