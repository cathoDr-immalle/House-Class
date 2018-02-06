using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassHouse
{
    class Door
    {
        public string Color { get; set; }

        public void ShowData()
        {
            Console.WriteLine("De kleur van mijn voordeur is {0}.", Color);
        }
    }
}
