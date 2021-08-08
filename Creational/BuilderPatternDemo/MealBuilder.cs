using BuilderPatternDemo.FoodItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            Meal meal = new();
            meal.addItem(new VegBurger());
            meal.addItem(new Coke());
            return meal;
        }

        public Meal prepareChickenMeal()
        {
            Meal meal = new();
            meal.addItem(new ChickenBurger());
            meal.addItem(new Pepsi());
            return meal;
        }
    }

}
