using AbstractFactoryPatternDemo.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Factories
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(string shapeType);
    }
}
