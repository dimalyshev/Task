using System;
using Figures.Abstraction;
using Figures;
using Xunit;


namespace SquareCalculator.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData( 2, 3.9375)]
        [InlineData(1, 3)]
        [InlineData(2, 4)]
        // [InlineData()]
        public void TestSquares(double r, double s)
        {
            // arrange
            var f = new Circle(r);
            // act
            var v = f.GetValue();
            // assert
            Assert.Equal(v, s / Math.PI);
        }
    }
}
