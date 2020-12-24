﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private const int MinNameLenght = 3;
        private const int MinAge = 1;
        private const decimal MinSalary = 460;

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length < MinNameLenght)
                {
                    throw new ArgumentException($"First name cannot contain fewer than {MinNameLenght} symbols!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < MinNameLenght)
                {
                    throw new ArgumentException($"Last name cannot contain fewer than {MinNameLenght} symbols!");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < MinAge)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                this.age = value;
            }
        }

        public decimal Salary
        {
            get => this.salary;
            private set
            {
                if (value < MinSalary)
                {
                    throw new ArgumentException($"Salary cannot be less than {MinSalary} leva!");
                }

                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            bool isYounger = this.Age < 30;
            if (isYounger)
            {
                percentage /= 2;
            }

            this.Salary += this.Salary * percentage / 100;
        }

        public override string ToString()
        {
            //return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }
    }
}
