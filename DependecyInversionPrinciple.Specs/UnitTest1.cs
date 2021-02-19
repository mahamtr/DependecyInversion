using System;
using Moq;
using Xunit;

namespace DependecyInversionPrinciple.Specs
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldSucceed()
        {
            var stringConverterMock = new Mock<IStringConverter>();
            stringConverterMock.Setup(s => s.ConvertStringToNumbers("1,3,4,5"))
                .Returns(new int[] {1, 3, 4, 5});
       
            //arrange
            var stringCalculator = new Calculator(stringConverterMock.Object);
            var result = 13;
            //act
            var response = stringCalculator.Add("1,3,4,5");
            
            
            //asert
            
            Assert.Equal(response,result);
        }
    }
}