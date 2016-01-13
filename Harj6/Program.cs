using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kuinka monta kilometriä olet ajanut?");
            string rivi = Console.ReadLine();
            int luku = int.Parse(rivi);

            double kulutus = luku * 7.02/100;
            double hinta = kulutus * 1.595;

            Console.WriteLine("Kulutuksesi on: " + kulutus);
            Console.WriteLine("Hintaa tulee: " + hinta);
            Console.ReadLine();
        }
    }
}
