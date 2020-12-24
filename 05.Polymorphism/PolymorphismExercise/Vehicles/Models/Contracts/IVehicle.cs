﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelCnsumptionPerKm { get; }

        double TankCapacity { get; }

        string Drive(double distance);

        void Refuel(double liters);
    }
}
