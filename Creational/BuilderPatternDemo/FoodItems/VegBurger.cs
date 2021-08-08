using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo.FoodItems
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 3.99f;
        }
    }
}
