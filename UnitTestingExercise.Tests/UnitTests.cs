using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 2, 2, 6)] //Add test data <-------
        [InlineData(1, 0, 0, 1)] //Add test data <-------
       
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            Calculator instance = new Calculator();

            int actual = instance.Add(num1, num2, num3);
            
        }

        [Theory]
        [InlineData(2, 2, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator instance = new Calculator();

            //Act
            int actual = instance.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 4, 16)]//Add test data <-------
        [InlineData(5, 10, 50)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance = new Calculator();

            //Act
            var actual = instance.Multiply(num1, num2); 
            
            Assert.Equal(expected, actual);
            //Assert

        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(2, 2, 1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator instance = new Calculator();

            //Act
            int actual = instance.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
