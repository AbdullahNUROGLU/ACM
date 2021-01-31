using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositorytest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            OrderRepository orderRepository = new OrderRepository();
            Order expected = new Order
            {
                OrderDate = new DateTimeOffset()
            };
            //Act
            Order actual = orderRepository.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}