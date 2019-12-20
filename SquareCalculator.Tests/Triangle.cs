using System;
using Figures.Abstraction;
using Figures;
using Xunit;


namespace SquareCalculator.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(3, 2, 2, 3.9375)]
        [InlineData(2, 2, 2, 3)]
        [InlineData(1, 1, 1, 3)]
        // [InlineData()]
        public void TestSquares(double a, double b, double c, double s)
        {
            // arrange
            var f = new Triangle(a, b, c);
            // act
            var v = f.GetValue();
            // assert
            Assert.Equal(Math.Sqrt(s), v);
        }
    }
}
