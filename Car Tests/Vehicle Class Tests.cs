using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary.Models;
using System;


namespace Car_Tests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void ReturnVehicleTypeCorrectly ()
        {
            // Arrange
            Car car = new Car("abc123");
            string expectedResult = "Car";

            // Act
            string actualResult = car.VehicleType;

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Results are not equal");
            
        }

        [TestMethod]
        public void ReturnPriceAs240()
        {
            // Arrange
            Car car = new Car("abc123");
            double expectedResult = 240;

            // Act
            double actualResult = car.Price;

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Results are not equal");
        }
    }

    [TestClass]
    public class MotorCycleTest
    {
        [TestMethod]
        public void ReturnVehicleTypeCorrectly()
        {
            // Arrange
            MotorCycle motorCycle = new MotorCycle("abc123");
            string expectedResult = "Motor Cycle";

            // Act
            string actualResult = motorCycle.VehicleType;

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Results are not equal");

        }

        [TestMethod]
        public void ReturnPriceAs240()
        {
            // Arrange
            MotorCycle motorCycle = new MotorCycle("abc123");
            double expectedResult = 125;

            // Act
            double actualResult = motorCycle.Price;

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "Results are not equal");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException), "License plate is more then 7 characters")]
        public void ErrorIfLicenseLongerThenSevenCharacters()
        {
            // Arrange
            MotorCycle motorCycle = new MotorCycle("123456");

            Assert.ThrowsException<ArgumentOutOfRangeException>(ErrorIfLicenseLongerThenSevenCharacters);

        }

    }
}
