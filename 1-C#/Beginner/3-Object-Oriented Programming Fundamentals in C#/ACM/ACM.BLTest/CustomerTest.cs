using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "mahmoud";
            customer.LastName = "khaled";
            customer.EmailAddress = "mahmoudkhaled01020@gmail.com";

            string expected = "mahmoud khaled";

            //Act
            string actual = customer.FullName;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "mahmoud";
            customer.LastName = "khaled";


            //string expected = "mahmoud"; //Error
            string expected = "mahmoud khaled"; //correct

            //Act
            string actual = customer.FullName;


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateValid()
        {
            //Arrang
            var customer = new Customer();
            customer.EmailAddress = "mahmoud@gmail.com";
            customer.LastName = "Khaled";
            var expected = true;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
