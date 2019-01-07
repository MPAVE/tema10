using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle:Shape
    {
        public Rectangle ( int Weight, int Height)
        {
            width = Weight;
            height = Height;
        }
        public override int CalculateSurface()
        {
            return width * height;
        }
        public override string GetShapeType()
        {
            return "Rectangle";
        }
    }
}
