using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1)
            {
                FirstName = "Apo",
                LastName = "kajj",
                EmailAddress = "busy.heart@live.com"
            };
            //Act
            Customer actual = customerRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}