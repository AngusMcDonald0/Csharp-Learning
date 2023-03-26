using NUnit.Framework;
using TestNinja.Fundamentals;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase (-1)]
        [TestCase (301)]
        public void CalculateDemeritPoints_SpeedOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase (0, 0)]
        [TestCase (64, 0)]
        [TestCase (65, 0)]
        [TestCase (66, 0)]
        [TestCase (70, 1)]
        [TestCase (75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemerits(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();
            var result = calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
