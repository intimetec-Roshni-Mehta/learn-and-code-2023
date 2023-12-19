using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KprConstUnitTest
{
    [TestClass]
    public class KaprekarConstantTests
    {

        [TestMethod]
        public void TestKaprekarFormula_SingleIteration_Returns6174()
        {
            // Arrange
            int inputNumber = 3524;

            // Act
            int result = KaprekarsConstant.KaprekarFormula(inputNumber);

            // Assert
            Assert.AreEqual(6174, result);
        }

        [TestMethod]
        public void TestKaprekarFormula_MultipleIterations_Returns6174()
        {
            // Arrange
            int inputNumber = 3521;

            // Act
            int result = KaprekarsConstant.PerformKaprekarFunction(inputNumber);

            // Assert
            Assert.AreEqual(6174, result);
        }

        [TestMethod]
        public void TestKaprekarFormula_InvalidInput_ThrowsException()
        {
            // Arrange
            int inputNumber = 999;

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() => KaprekarsConstant.PerformKaprekarFunction(inputNumber));
        }

        [TestMethod]
        public void TestKaprekarFormula_MinimumFourDigitNumber_Returns6174()
        {
            // Arrange
            int inputNumber = 1000;

            // Act
            int result = KaprekarsConstant.PerformKaprekarFunction(inputNumber);

            // Assert
            Assert.AreEqual(6174, result);
        }

        [TestMethod]
        public void TestKaprekarFormula_IdenticalDigits_ReturnsZeroIterations()
        {
            // Arrange
            int inputNumber = 1111;

            // Act
            int result = KaprekarsConstant.PerformKaprekarFunction(inputNumber);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestKaprekarFormula_ThreeIdenticalDigits_Returns6174()
        {
            // Arrange
            int inputNumber = 2111;

            // Act
            int result = KaprekarsConstant.PerformKaprekarFunction(inputNumber);

            // Assert
            Assert.AreEqual(6174, result);
        }
    }
}
