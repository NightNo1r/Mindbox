using System;
using ShapeLib.Abstractions;

namespace ShapeLib
{
    public class Circle : IShape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}