using BuilderPatternDemo.Packings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo.FoodItems
{
    public abstract class Burger : Item
    {
        public abstract string Name();
        public Packing Packing()
        {
            return new Wrapper();
        }
        public abstract float Price();
    }
}
