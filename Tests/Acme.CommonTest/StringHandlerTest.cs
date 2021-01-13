using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void IsertSpaceTestValid()
        {
            //Arrange
            string expexted = "Name Test";

            //Act
            string actual = StringHandler.InsertSpaces("NameTest");

            //Assert
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void IsertSpaceTestWithExistingSpace()
        {
            //Arrange
            string expexted = "Name Test";

            //Act
            string actual = StringHandler.InsertSpaces("Name Test");

            //Assert
            Assert.AreEqual(expexted, actual);
        }
    }
}