using System;
using ShapeLib.Abstractions;

namespace ShapeLib
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(
            double sideA,
            double sideB,
            double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            const double allowedTolerance = 0.0001;

            return Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) < allowedTolerance ||
                   Math.Abs(Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) < allowedTolerance ||
                   Math.Abs(Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) < allowedTolerance;
        }
    }
}