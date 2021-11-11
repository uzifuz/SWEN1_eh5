using System;
using System.Collections.Generic;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Triangle : Shape, IShapeComposition
    {
        private int _x2, _y2, _x3, _y3;
        public Triangle(int x, int y, int x2, int y2, int x3, int y3) : base(x, y)
        {
            _x2 = x2;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;
        }
        public double GetArea()
        {
            return
                (MathF.Abs((MathF.Sqrt(_x * _x + _y * _y) - MathF.Sqrt(_x2 * _x2 + _y2 * _y2)))
               * MathF.Abs((MathF.Sqrt(_x * _x + _y * _y) - MathF.Sqrt(_x3 * _x3 + _y3 * _y3))))
               / 2;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a triangle");
        }

        public override void ShowOrigin()
        {
            base.ShowOrigin();
        }

    }
}
