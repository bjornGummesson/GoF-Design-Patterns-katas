﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo.Shapes
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
