using System;
using Figures.Abstraction;

namespace Figures
{
    public partial class Circle : ISquarable
    {
        double ISquarable.Value => Math.PI * _radius * _radius;
    }
}
