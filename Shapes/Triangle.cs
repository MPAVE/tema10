using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle: Shape
    {
        public Triangle(int Widht, int Height)
        {
            width = Widht;
            height = Height;
        }

        public override int CalculateSurface()
        {
            return height * width / 2;
        }
        public override string GetShapeType()
        {
            return "Triangle";
        }
    }
}
