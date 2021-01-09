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
    }
}