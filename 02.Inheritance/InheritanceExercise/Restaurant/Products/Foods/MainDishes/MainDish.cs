﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Products.Foods.MainDishes
{
    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) 
            : base(name, price, grams)
        {
        }
    }
}
