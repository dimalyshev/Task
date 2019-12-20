using System;

namespace Figures
{
    public partial class Triangle
    {
        readonly (double a, double b, double c) _sides;

        public Triangle(double a, double b, double c)
         => _sides = (a: a, b: b, c: c);

        public bool IsIsosceles
            => _sides.a == _sides.b
            || _sides.a == _sides.c
            || _sides.b == _sides.c;
    }
}
