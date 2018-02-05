using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassHouse
{
    class Door
    {
        public string Color
        {
            get
            {
                
                return Color;
            }
            set { }
        }

        public void ShowData(string Invul)
        {
            Console.WriteLine("De kleur van mijn voordeur is {0}.", Invul);
        }
    }
}
