using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expexted = new Customer(1)
            {
                EmailAddress = "busy.heart@live.com",
                FirstName = "Apo",
                LastName = "kajj",
                AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        AddressType = 1,
                        StreetLine1 = "line1",
                        StreetLine2 = "line2",
                        City = "city",
                        Country = "country",
                        PostalCode = "144",
                    },
                    new Address(2)
                    {
                        AddressType = 1,
                        StreetLine1 = "line1",
                        StreetLine2 = "line2",
                        City = "city",
                        Country = "country",
                        PostalCode = "144",
                    }
                }
            };

            //Act
            Customer actual = customerRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expexted.CustomerId, actual.CustomerId);
            Assert.AreEqual(expexted.FirstName, actual.FirstName);
            Assert.AreEqual(expexted.LastName, actual.LastName);
            Assert.AreEqual(expexted.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < actual.AddressList.Count; i++)
            {
                Assert.AreEqual(expexted.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expexted.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expexted.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expexted.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expexted.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expexted.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}