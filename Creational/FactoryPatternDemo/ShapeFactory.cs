using FactoryPatternDemo.Interfaces;
using FactoryPatternDemo.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class ShapeFactory
    {
        public Shape getShape(string shapeName)
        {
            switch (shapeName)
            {
                case "circle":
                    return new Circle();
                case "triangle":
                    return new Triangle();
                case "rectangle":
                    return new Rectangle();
                default:
                    return null;
            }

        }
    }
}
