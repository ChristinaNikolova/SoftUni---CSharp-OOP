﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Products.Beverages.ColdBeverages
{
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {
        }
    }
}
