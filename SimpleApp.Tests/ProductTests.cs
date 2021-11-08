using SimpleApp.Models;
using Xunit;

namespace SimpleApp.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            //Arrange
            var p = new Product { Name = "Test", Price = 100M };

            //Act
            p.Name = "New Name";

            //Assert
            Assert.Equal("New Name", p.Name);

        }
         
        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };
            // Act
            p.Price = 200M;
            //Assert
            Assert.Equal(200M, p.Price);
        }
        //Assert.NotEqual(100M, p.Price);
        //The problem with the unit test is with the arguments to the Assert.
        //Equal method, which compares the test result to the original 
        //Price property value rather than the value it has been changed to.
    }
}
