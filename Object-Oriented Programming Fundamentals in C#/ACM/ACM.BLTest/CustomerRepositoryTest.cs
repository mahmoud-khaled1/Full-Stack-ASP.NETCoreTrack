using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAddress = "aly@gmail.com",
                FirstName = "Aly",
                LastName = "Ahmed"
            };
            //Act
            var actual = customerRepository.Retrive(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, expected.EmailAddress);
        }
    }
}
