
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});
            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user};
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_OtherUserCancelling_ReturnsFalse()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);

        }
    }
}