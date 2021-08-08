using FactoryPatternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.Shapes
{
    public class Triangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
}
