using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OPTIMIZACIJA:
//razredi po datotekah (drugače je nepregledno)
//oblika se izbere pred velikostjo

namespace Vaja___Karica_2.del
{
    class Program
    {
        static int Vnos()
        {
            int stevilo = int.Parse(Console.ReadLine());
            return stevilo;
        }

        static int Meni()
        {
            Console.WriteLine("Meni:");
            Console.WriteLine("1 - Obroba karice");
            Console.WriteLine("2 - Parni zmaj");
            Console.WriteLine("3 - Navadna karica");
            Console.WriteLine();
            int izbira = -1;

            do { 
                try
                {
                    Console.Write("Izbira: ");
                    izbira = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Napaka pri vpisu.");
                }

                if (izbira < 1 || izbira > 3) { 
                    Console.WriteLine("Vnesen izbira je izven zahtevanih mej. Prosimo vas za ponoven vpis.\n");}

            } while (izbira < 1 || izbira > 3);

            return izbira;
        }

        static void Main(string[] args)
        {
            int x = -1; //vnos dolžine
            int izbira = -1;

            //izbira oblike
            izbira = Meni();
            Console.WriteLine();

            do
            {
                //vpis velikosti karica
                try
                {
                    Console.Write("Vpišite število med 3 in 40: ");
                    x = Vnos();
                }
                catch
                {
                    Console.WriteLine("Napaka pri vpisu.");
                }

                //izvedba
                if (x < 3 || x > 40)
                {
                    Console.WriteLine("Vneseno število je izven zahtevanih mej, ponovite ali vpisi 0 za izhod.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();

                    if (izbira == 1)
                    {
                        ObrobaKarice K = new ObrobaKarice();
                        K.Izris(x);
                    }
                    else if (izbira == 2)
                    {
                        ParniZmaj P = new ParniZmaj();
                        P.Izris(x);
                    }
                    else //(izbira == 3)
                    {
                        Karica X = new Karica();
                        X.Izris(x);
                    }
                }
            } while ((x < 3 || x > 40) && (x != 0));
            Console.ReadKey(true);
        }
    }
}
