using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kolme lukua ");
            Console.Write("Eka: ");
            string rivi = Console.ReadLine();
            int luku1 = int.Parse(rivi);
            Console.Write("Toinen: ");
            string rivi2 = Console.ReadLine();
            int luku2 = int.Parse(rivi2);
            Console.Write("Kolmas");
            string rivi3 = Console.ReadLine();
            int luku3 = int.Parse(rivi3);

            int summa = luku1 + luku2 + luku3;
            float ka = summa / 3;
            Console.WriteLine("Summasi on: "+ summa);
            Console.WriteLine("Keskiarvosi on: "+ ka);
            Console.ReadLine();

        }
    }
}
