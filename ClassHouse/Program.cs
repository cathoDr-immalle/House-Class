using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jefke = new Person("Jefke");
            House huis = new House(50);
            Door deur = new Door();

            jefke.ShowData();
            huis.ShowData();
            deur.ShowData("bruine");
            
        }
    }
}
