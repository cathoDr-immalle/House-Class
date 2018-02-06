using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassHouse
{
    class House
    {
        public int Area { get; set; }
        public Door Frontdoor { get; set; }

        public House(int area)
        {
            this.Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine("Mijn huis heeft {0} m² als oppervlakte", Area);
            Console.WriteLine("En hier is wat info over mijn Voordeur:");
            Frontdoor.ShowData();
        }

        
    }
}
