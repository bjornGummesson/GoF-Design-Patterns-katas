﻿using BuilderPatternDemo.Packings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo.FoodItems
{
    public interface Item
    {
        public string Name();
        public Packing Packing();
        public float Price();
    }
}
