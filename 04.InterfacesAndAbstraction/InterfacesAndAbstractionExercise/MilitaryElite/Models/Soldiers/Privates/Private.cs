﻿using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Soldiers.Privates
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:F2}";
        }
    }
}
