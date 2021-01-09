using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CutomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Apo",
                LastName = "kajj"
            };
            string expexted = "kajj, Apo";
            //act
            string actual = customer.FullName;
            //assert
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void FirstNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                FirstName = "Apo"
            };
            string expexted = "Apo";
            //act
            string actual = customer.FullName;
            //assert
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void LastNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                LastName = "kajj"
            };
            string expexted = "kajj";
            //act
            string actual = customer.FullName;
            //assert
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            Customer c1 = new Customer();
            c1.FirstName = "c1";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c2.FirstName = "c2";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c3.FirstName = "c3";
            Customer.InstanceCount += 1;
            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            Customer customer = new Customer
            {
                LastName = "kajj",
                EmailAddress = "busy.heart@live.com"
            };

            bool expexted = true;
            bool actual = customer.Valid();
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            Customer customer = new Customer
            {
                EmailAddress = "busy.heart@live.com"
            };

            bool expexted = false;
            bool actual = customer.Valid();
            Assert.AreEqual(expexted, actual);
        }
    }
}