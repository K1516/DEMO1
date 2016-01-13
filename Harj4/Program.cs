using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ikäsi: ");
            string rivi = Console.ReadLine();
            int luku = int.Parse(rivi);
            if (luku < 18) {
                Console.WriteLine("Olet alaikäinen!");
            }

            else if (luku >= 18 && 65 > luku)
                Console.WriteLine("Olet aikuinen!");
        
            
                else if (luku >= 65)
                    Console.WriteLine("Olet seniori!");
            Console.ReadLine();
        }

        }

    }

