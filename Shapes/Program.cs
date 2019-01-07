using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle(20, 10);
            Rectangle r2 = new Rectangle(20, 20);
            Triangle t1 = new Triangle(20, 10);
            Triangle t2 = new Triangle(30, 5);
            Square s1 = new Square(20);
            Square s2 = new Square(40);

         
            List<Shape> list = new List<Shape>();
           
            list.Add(r1);
            list.Add(r2);
            list.Add(t1);
            list.Add(t2);
            list.Add(s1);
            list.Add(s2);


            foreach ( var item in list)
            {
                Console.WriteLine($" aria  {item.GetShapeType()} are valoarea: {item.CalculateSurface()}");

            }
            Console.ReadLine();
        }
    }
}
