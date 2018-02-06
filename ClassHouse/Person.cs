﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassHouse
{
    class Person
    {
        private string naam;
        public House House { get; set; }

        public Person(string naam)
        {
            this.naam = naam;
        }

        public void ShowData()
        {
            Console.WriteLine("Mijn naam is {0}.", naam);
            Console.WriteLine("En hier is wat info over mijn huis:");
            House.ShowData();
        }
    }
}
