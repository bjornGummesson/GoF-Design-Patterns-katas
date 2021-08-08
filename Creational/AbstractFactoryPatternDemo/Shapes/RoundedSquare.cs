using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Shapes
{
    public class RoundedSquare : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rounded Square");
        }
    }
}
