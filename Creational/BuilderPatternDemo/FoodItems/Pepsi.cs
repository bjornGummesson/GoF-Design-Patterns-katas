using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo.FoodItems
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 1.55f;
        }
    }
}
