using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public int height;
        public int width;

        public abstract int CalculateSurface();
      
        public abstract string GetShapeType();
    }
}
