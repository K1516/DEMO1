using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pisteesi : ");
            string rivi = Console.ReadLine();
            int luku;
            bool onnistuiko = int.TryParse(rivi, out luku);
            if (onnistuiko)
            {
                switch (luku)
                {
                    case 0: Console.WriteLine("Arvosanasi : 0");
                            break;
                    case 1: Console.WriteLine("Arvosanasi : 0");
                        break;
                    case 2:  Console.WriteLine("Arvosanasi : 1");
                        break;
                    case 3: Console.WriteLine("Arvosanasi : 1");
                        break;
                    case 4: Console.WriteLine("Arvosanasi : 2");
                        break;
                    case 5: Console.WriteLine("Arvosanasi : 2");
                        break;
                    case 6: Console.WriteLine("Arvosanasi : 3");
                        break;
                    case 7: Console.WriteLine("Arvosanasi : 3");
                        break;
                    case 8: Console.WriteLine("Arvosanasi : 4");
                        break;
                    case 9: Console.WriteLine("Arvosanasi : 4");
                        break;
                    case 10: Console.WriteLine("Arvosanasi : 5");
                        break;
                    case 11: Console.WriteLine("Arvosanasi : 5");
                        break;
                    case 12: Console.WriteLine("Arvosanasi : 5");
                        break;
                }
            } else
            {
                Console.WriteLine("Pistemäärä ei vastaa arvostelua, ootko jumala??");
            }
            Console.ReadLine();
        }
    }
}
