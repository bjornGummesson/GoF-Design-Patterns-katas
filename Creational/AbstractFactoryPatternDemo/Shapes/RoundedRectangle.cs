﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Shapes
{
    public class RoundedRectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rounded Rectangle");
        }
    }
}
