﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.name = value;
            }
        }

        public IReadOnlyCollection<Person> FirstTeam => this.firstTeam.AsReadOnly();

        public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam.AsReadOnly();

        public void AddPlayer(Person person)
        {
            bool isYounger = person.Age < 40;
            if (isYounger)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }
    }
}
