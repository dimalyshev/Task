using System;
using Figures.Abstraction;
using Figures;
using Xunit;


namespace SquareCalculator.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(2, 4)]
        [InlineData(1, 1)]
        [InlineData(4, 16)]
        public void TestSquares(double r, double s)
        {
            // arrange
            var f = new Circle(r);
            // act
            var v = f.GetValue();
            // assert
            Assert.Equal(s * Math.PI, v);
        }
    }
}
