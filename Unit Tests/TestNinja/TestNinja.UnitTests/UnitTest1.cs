
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});
            // Assert
            Assert.IsTrue(result);
        }

        public void CanBeCancelledBy_ReservationMadeByUser_ReturnsTrue()
        {

        }

        public void CanBeCancelledBy_NotMadeByUserOrAdmin_ReturnsTrue()
        {

        }
    }
}