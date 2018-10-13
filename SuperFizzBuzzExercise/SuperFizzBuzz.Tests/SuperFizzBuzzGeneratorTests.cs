using System;
using Xunit;
using Moq;
using SuperFizzBuzz;

namespace SuperFizzBuzzTests
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
    }
}
