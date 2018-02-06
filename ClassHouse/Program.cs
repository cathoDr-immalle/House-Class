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
            Door deur = new Door();
            House huis = new House(50);
            Person joske = new Person("Joske");
            
            deur.Color = "Blauw";
            deur.ShowData();

            Console.WriteLine("");
            huis.Frontdoor = deur;
            huis.ShowData();

            Console.WriteLine("");
            joske.House = huis;
            joske.ShowData();

        }
    }
}
