using System;
using System.Collections.Generic;
using Xunit;

namespace SuperFizzBuzz.Tests
{
    public class FizzBuzzTokenizerAdvancedTests
    {
        private FizzBuzzTokenizer fizzBuzzTokenizer;

        public FizzBuzzTokenizerAdvancedTests()
        {
            fizzBuzzTokenizer = new FizzBuzzTokenizer();
        }

        [Fact]
        public void CanGetToken_WhenMinus12_ReturnsFizz()
        {
            //Arrange
            var value = -12;
            var options = new Dictionary<int, string> {
                {3, "Fizz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void CanGetToken_When145_Returns145()
        {
            //Arrange
            var value = 145;
            var options = new Dictionary<int, string>();

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("145", result);
        }

        [Fact]
        public void CanGetToken_When0_Returns0()
        {
            //Arrange
            var value = 0;
            var options = new Dictionary<int, string>();

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("0", result);
        }

        [Fact]
        public void CanGetToken_When3_ReturnsFizz()
        {
            //Arrange
            var value = 3;
            var options = new Dictionary<int, string> {
                {3, "Fizz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void CanGetToken_When7_ReturnsBuzz()
        {
            //Arrange
            var value = 7;
            var options = new Dictionary<int, string> {
                {7, "Buzz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void CanGetToken_When38_ReturnsBazz()
        {
            //Arrange
            var value = 38;
            var options = new Dictionary<int, string> {
                {38, "Bazz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Bazz", result);
        }

        [Fact]
        public void CanGetToken_When21_ReturnsFizzBuzz()
        {
            //Arrange
            var value = 21;
            var options = new Dictionary<int, string> {
                {3, "Fizz"},
                {7, "Buzz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void CanGetToken_When114_ReturnsFizzBazz()
        {
            //Arrange
            var value = 114;
            var options = new Dictionary<int, string> {
                {3, "Fizz"},
                {38, "Bazz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("FizzBazz", result);
        }

        [Fact]
        public void CanGetToken_When54_ReturnsFizz()
        {
            //Arrange
            var value = 54;
            var options = new Dictionary<int, string> {
                {3, "Fizz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void CanGetToken_When63_ReturnsFizzBuzz()
        {
            //Arrange
            var value = 63;
            var options = new Dictionary<int, string> {
                {3, "Fizz"},
                {7, "Buzz"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void CanGetToken_When88_Returns88()
        {
            //Arrange
            var value = 88;
            var options = new Dictionary<int, string>();

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("88", result);
        }

        [Fact]
        public void CanGetToken_When4_ReturnsFrog()
        {
            //Arrange
            var value = 4;
            var options = new Dictionary<int, string> {
                {4, "Frog"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Frog", result);
        }

        [Fact]
        public void CanGetToken_When13_ReturnsDuck()
        {
            //Arrange
            var value = 13;
            var options = new Dictionary<int, string> {
                {13, "Duck"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Duck", result);
        }

        [Fact]
        public void CanGetToken_When9_ReturnsChicken()
        {
            //Arrange
            var value = 9;
            var options = new Dictionary<int, string> {
                {9, "Chicken"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("Chicken", result);
        }

        [Fact]
        public void CanGetToken_When52_ReturnsFrogDuck()
        {
            //Arrange
            var value = 52;
            var options = new Dictionary<int, string> {
                {4, "Frog"},
                {13, "Duck"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("FrogDuck", result);
        }

        [Fact]
        public void CanGetToken_When36_ReturnsFrogChicken()
        {
            //Arrange
            var value = 36;
            var options = new Dictionary<int, string> {
                {4, "Frog"},
                {9, "Chicken"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("FrogChicken", result);
        }

        [Fact]
        public void CanGetToken_When468_ReturnsFrogDuckChicken()
        {
            //Arrange
            var value = 468;
            var options = new Dictionary<int, string> {
                {4, "Frog"},
                {13, "Duck"},
                {9, "Chicken"}
            };

            //Act
            var result = fizzBuzzTokenizer.GetToken(value, options);

            //Assert
            Assert.Equal("FrogDuckChicken", result);
        }
    }
}
