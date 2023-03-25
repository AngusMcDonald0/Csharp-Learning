using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class ErrorLoggerTests
    {
        private ErrorLogger _Logger;

        [SetUp]
        public void SetUp()
        {
            _Logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty() 
        {
            _Logger.Log("a");

            Assert.That(_Logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error) 
        {
            Assert.That(() => _Logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var id = Guid.Empty;
            _Logger.ErrorLogged += (sender, args) => { id = args; };
            _Logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
