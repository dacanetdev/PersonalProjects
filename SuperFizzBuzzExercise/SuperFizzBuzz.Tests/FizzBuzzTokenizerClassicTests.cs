using System;
using Xunit;
using SuperFizzBuzz;

namespace SuperFizzBuzz.Tests
{
    public class FizzBuzzTokenizerClassicTests
    {
        private FizzBuzzTokenizer fizzBuzzTokenizer;

        public FizzBuzzTokenizerClassicTests()
        {
            fizzBuzzTokenizer = new FizzBuzzTokenizer();
        }

        [Fact]
        public void CanGetToken_When1_Returns1()
        {
            //Arrange
            var value = 1;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void CanGetToken_When100_ReturnsBuzz()
        {
            //Arrange
            var value = 100;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void CanGetToken_When2_Returns2()
        {
            //Arrange
            var value = 2;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("2", result);
        }

        [Fact]
        public void CanGetToken_When3_ReturnsFizz()
        {
            //Arrange
            var value = 3;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void CanGetToken_When5_ReturnsBuzz()
        {
            //Arrange
            var value = 5;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void CanGetToken_When15_ReturnsFizzBuzz()
        {
            //Arrange
            var value = 15;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void CanGetToken_When11_Returns11()
        {
            //Arrange
            var value = 11;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("11", result);
        }

        [Fact]
        public void CanGetToken_When27_ReturnsFizz()
        {
            //Arrange
            var value = 27;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void CanGetToken_When55_ReturnsBuzz()
        {
            //Arrange
            var value = 55;

            //Act
            var result = fizzBuzzTokenizer.GetToken(value);

            //Assert
            Assert.Equal("Buzz", result);
        }
    }
}
