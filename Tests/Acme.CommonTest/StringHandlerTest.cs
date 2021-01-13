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
            StringHandler stringHandler = new StringHandler();
            string expexted = "Name Test";

            //Act
            string actual = stringHandler.InsertSpaces("NameTest");

            //Assert
            Assert.AreEqual(expexted, actual);
        }

        [TestMethod]
        public void IsertSpaceTestWithExistingSpace()
        {
            //Arrange
            StringHandler stringHandler = new StringHandler();
            string expexted = "Name Test";

            //Act
            string actual = stringHandler.InsertSpaces("Name Test");

            //Assert
            Assert.AreEqual(expexted, actual);
        }
    }
}