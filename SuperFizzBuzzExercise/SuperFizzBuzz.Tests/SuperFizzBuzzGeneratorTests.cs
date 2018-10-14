using Xunit;
using Moq;

namespace SuperFizzBuzz.Tests
{
    public class SuperFizzBuzzGeneratorTests
    {
        [Fact]
        public void CanGenerate_Classic_Should_StartLimit1_EndLimit100()
        {
            //Arrange
            var startLimit = 1;
            var endLimit = 100;
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(new FizzBuzzTokenizer());

            //Act
            superFizzBuzzGenerator.GenerateClassic();

            //Assert
            Assert.Equal(startLimit, superFizzBuzzGenerator.StartLimit);
            Assert.Equal(endLimit, superFizzBuzzGenerator.EndLimit);
        }

        [Fact]
        public void CanGenerate_Classic_Should_CallExecute100Times()
        {
            //Arrange
            var mockFizzBuzzTokenizer = new Mock<IFizzBuzzTokenizer>();
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(mockFizzBuzzTokenizer.Object);

            //Act
            superFizzBuzzGenerator.GenerateClassic();

            //Assert
            mockFizzBuzzTokenizer.Verify(sfbg => sfbg.Execute(It.IsAny<int>()), Times.Exactly(100));
        }

        [Fact]
        public void CanGenerate_Advanced_When_startLimit2_endLimit35_Should_StartLimit2_EndLimit35()
        {
            //Arrange
            var startLimit = 2;
            var endLimit = 35;
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(new FizzBuzzTokenizer());

            //Act
            superFizzBuzzGenerator.GenerateAdvanced(startLimit, endLimit);

            //Assert
            Assert.Equal(startLimit, superFizzBuzzGenerator.StartLimit);
            Assert.Equal(endLimit, superFizzBuzzGenerator.EndLimit);
        }

        [Fact]
        public void CanGenerate_Advanced_When_startLimit2_endLimit35_Should_CallExecute34Times()
        {
            //Arrange
            var startLimit = 2;
            var endLimit = 35;
            var mockFizzBuzzTokenizer = new Mock<IFizzBuzzTokenizer>();
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(mockFizzBuzzTokenizer.Object);

            //Act
            superFizzBuzzGenerator.GenerateAdvanced(startLimit, endLimit);

            //Assert
            mockFizzBuzzTokenizer.Verify(sfbg => sfbg.Execute(It.IsAny<int>()), Times.Exactly(34));
        }

        [Fact(Skip = "Inconcluse")]
        public void CanGenerate_Advanced_When_startLimitMinus1_endLimitMinus35_Should_StartLimitMinus1_EndLimitMinus35()
        {
            //Arrange
            var startLimit = -1;
            var endLimit = -35;
            var superFizzBuzzGenerator = new SuperFizzBuzzGenerator(new FizzBuzzTokenizer());

            //Act
            superFizzBuzzGenerator.GenerateAdvanced(startLimit, endLimit);

            //Assert
            Assert.Equal(startLimit, superFizzBuzzGenerator.StartLimit);
            Assert.Equal(endLimit, superFizzBuzzGenerator.EndLimit);
        }

    }
}
