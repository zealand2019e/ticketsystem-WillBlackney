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

        public void TestBrobizzDiscount()
        {
            // Arrange
            double expectedResult = 240 * 0.95;

            // Act
            Car car = new Car("12345", true);

            // Assert
            Assert.AreEqual(expectedResult, car.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "License plate is more then 7 characters")]
        public void ErrorIfLicenseLongerThenSevenCharacters()
        {
            // Arrange + Act
            Car car = new Car("12345678");

            // Assert
            Assert.Fail();

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
        public void TestBrobizzDiscount()
        {
            // Arrange
            double expectedResult = 125 * 0.95;

            // Act
            MotorCycle motorCycle = new MotorCycle("12345", true);

            // Assert
            Assert.AreEqual(expectedResult, motorCycle.Price);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "License plate is more then 7 characters")]
        public void ErrorIfLicenseLongerThenSevenCharacters()
        {
            // Arrange + Act
            MotorCycle motorCycle = new MotorCycle("123456");

            // Assert
            Assert.Fail();

        }

    }
}
