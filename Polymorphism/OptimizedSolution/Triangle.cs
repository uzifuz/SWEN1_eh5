using System;
using System.Collections.Generic;
using System.Text;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    class Triangle : Shape, IShapeComposition
    {
        private int x2, y2, x3, y3;
        public Triangle(int x, int y, int x2, int y2, int x3, int y3) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public void PrintShapeType()
        {
            throw new NotImplementedException();
        }

        public override void ShowOrigin()
        {
            base.ShowOrigin();
        }

    }
}
