﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const int MinHorsePower = 70;
        private const int MaxHorsePower = 100;
        public PowerMotorcycle(string model, int horsePower)
            : base(model, horsePower, 450)
        {
        }

        //public  int HorsePower
        //{
        //    get => this.HorsePower;
        //    set
        //    {
        //        if (value < MinHorsePower || value > MaxHorsePower)
        //        {
        //            throw new ArgumentException($"Invalid horse power: {value}.");
        //        }

        //        this.HorsePower = value;
        //    }
        //}

        public override int HorsePower
        {
            get => base.HorsePower;
            protected set
            {
                if (value < MinHorsePower || value > MaxHorsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                base.HorsePower = value;
            }
        }
    }
}
