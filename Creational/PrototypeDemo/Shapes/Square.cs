using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo.Shapes
{
    public class Square : Shape
    {
        public Square()
        {
            Type = "Square";
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }
}
