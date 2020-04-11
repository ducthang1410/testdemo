using NUnit.Framework;
using FindUserID;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController customerController;

        [SetUp]
        public void SetUp()
        {
            customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = customerController.GetCustomer(0);
          
            Assert.That(result, Is.TypeOf<NotFound>());

            Assert.That(result, Is.InstanceOf<NotFound>());
        }
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = customerController.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}