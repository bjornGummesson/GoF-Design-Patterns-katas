using AbstractFactoryPatternDemo.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Factories
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "square":
                    return new RoundedSquare();
                case "rectangle":
                    return new RoundedRectangle();
                default:
                    return null;
            }
        }
    }
}
