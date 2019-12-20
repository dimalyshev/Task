using System;
using System.Linq;
using Figures.Abstraction;

namespace Figures
{
    public partial class Triangle : ISquarable
    {
        double ISquarable.Value
        {
            get
            {
                var f = new[] { _sides.a, _sides.b, _sides.c };
                var p = f.Sum();
                // prod = p * (p-a) * (p-b) * (p-c)
                var prod = f.Aggregate(p, (_, side) => _ * (p - side));
                return Math.Sqrt(prod);
            }
        }
    }
}
