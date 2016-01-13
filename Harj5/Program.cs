using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna niin monta sekunttia kuin haluat, muutan ne tunneiksi, minuuteiksi ja sekunneiksi: ");
            string rivi = Console.ReadLine();
            int sekunnit = int.Parse(rivi);
            int tunnit = sekunnit / 3600;
            int minuutit = sekunnit / 60 - tunnit * 60;
            int sekuntti = sekunnit / 60;
            Console.WriteLine(tunnit + " tuntia " + minuutit + " minuuttia " + sekuntti + " sekunttia ");
            Console.ReadLine();
        }
    }
}
