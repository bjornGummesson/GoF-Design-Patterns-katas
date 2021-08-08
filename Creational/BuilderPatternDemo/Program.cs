using System;

namespace BuilderPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new MealBuilder().prepareVegMeal().ShowItems();
            new MealBuilder().prepareChickenMeal().ShowItems();
        }
    }
}
