using Figures.Abstraction;

namespace Figures
{
    public static class SquarableExtension
    {
        public static double GetValue(this ISquarable figure)
            => figure.Value;
    }

}