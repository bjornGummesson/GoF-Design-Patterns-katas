using AbstractFactoryPatternDemo.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "rectangle":
                    return new Rectangle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
