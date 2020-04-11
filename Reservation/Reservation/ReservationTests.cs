using System;
using NUnit.Framework;
using Reservation;

namespace Reservation

{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

            // Assert 
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //Arrange
            var user123 = new User();
            var reservation = new Reservation {MadeBy = user123};

            //Act
            var result = reservation.CanBeCancelledBy(user123);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReturn_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };            

            //Act
            var result = reservation.CanBeCancelledBy( new User() );

            //Assert
            Assert.That(result, Is.True);
        }
    }
}
