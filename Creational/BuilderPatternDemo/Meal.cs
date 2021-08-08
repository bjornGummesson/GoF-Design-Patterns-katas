using BuilderPatternDemo.FoodItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class Meal
    {
        private List<Item> items = new();

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0f;

            foreach (var item in items)
            {
                cost += item.Price();
            }
            return cost;
        }
        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Item : {item.Name()}, Packing: {item.Packing().Pack()}, Price {item.Price()}");
            }
        }
    }
}
