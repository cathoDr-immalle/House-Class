using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassHouse
{
    class House
    {
        private int Area { get; set; }
        private Door Frontdoor { get; }

        public House(int Area)
        {
            this.Area = Area;
        }

        public void ShowData()
        {
            Console.WriteLine("Ik ben een huis met {0} m² als oppervlakte", Area);
        }

        
    }
}
