using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary.Models;


namespace Car_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnVehicleTypeCorrectly ()
        {
            // Arrange
            Car car = new Car();
            string expectedResult = "Car";

            // Act
            string actualResult = car.VehicleType();

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Results are not equal");
            
        }

        [TestMethod]
        public void ReturnPriceAs240()
        {
            // Arrange
            Car car = new Car();
            double expectedResult = 240;

            // Act
            double actualResult = car.Price();

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Results are not equal");
        }
    }
}
