﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                this.name = value;
            }
        }
    }
}
