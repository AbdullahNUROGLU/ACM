using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(1)
            {
                ProductName = "product",
                ProductDescription = "info",
                CurrentPrice = 15.96M
            };
            var actual = productRepository.Retrieve(1);

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            ProductRepository productRepository = new ProductRepository();
            Product updatedProduct = new Product(1)
            {
                ProductName = "product",
                ProductDisceiption = "info",
                CurrentPrice = 14.96M,
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            ProductRepository productRepository = new ProductRepository();
            Product product = new Product(1)
            {
                CurrentPrice = null,
                ProductDisceiption = "info",
                ProductName = "product",
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(product);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}