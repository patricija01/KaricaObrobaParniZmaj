using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja___Karica_2.del
{
    class Karica
    {
        protected int dolzina; //skupno število zvezdic in praznih polj med njimi
        protected int praznoPolje; //število praznih polj pred začetkom izrisa
        protected int presezeno;

        public void Izris(int stevilo)
        {
            //če je vneseno število parno, ga zmanjšamo za 1
            if (stevilo % 2 == 0)
                stevilo -= 1;

            int presezeno = 1; //ko karica preseže polovico izrisa
            int zvezdice = 1; //število zvezdic na začetku
            int praznoPolje = (stevilo - 1) / 2;

            string izpis = "";

            for (int i = 0; i < stevilo; i++) //število vrstic je enako vpisanemu številu
            {
                if (zvezdice == stevilo)
                    presezeno = -1;

                Console.Write(izpis.PadLeft(praznoPolje, ' '));

                if (presezeno == 1)
                {
                    Console.Write(izpis.PadLeft(zvezdice, '*'));
                    praznoPolje--;
                }
                else //presezeno == -1
                {
                    Console.Write(izpis.PadLeft(zvezdice, '*'));
                    praznoPolje++;
                }

                zvezdice += (presezeno) * 2;

                Console.WriteLine();
            }
        }
    }

    class ObrobaKarice:Karica
    {
        new public void Izris(int stevilo)
        {
            //če je vneseno število parno, ga zmanjšamo za 1
            if (stevilo % 2 == 0)
                stevilo -= 1;

            presezeno = 1; //ko karica preseže polovico izrisa            
            praznoPolje = (stevilo - 1) / 2; //pred začetkom karice
            dolzina = 1; //število zvezdic na začetku
            int prostor = dolzina - 2; //prostor med dvema zvezdicama

            string izpis = "";

            for (int i = 0; i < stevilo; i++) //število vrstic je enako vpisanemu številu
            {
                if (dolzina == stevilo)
                    presezeno = -1;

                Console.Write(izpis.PadLeft(praznoPolje, ' ')); //število praznih polj pred začetkom izrisa karice
                               
                //karica 
                Console.Write("*"); //prvi znak je vedno zvezdica

                if (i == 0 || i == stevilo - 1) //prva in zadnja vrstica se razlikujeta od ostalih, saj imata le eno zvezdico
                    praznoPolje--;
                else
                {                   
                    if (presezeno == 1)
                    {
                        Console.Write(izpis.PadLeft((dolzina - 2), ' '));
                        praznoPolje--;
                    }
                    else //presezeno == -1
                    {
                        Console.Write(izpis.PadLeft(dolzina - 2, ' '));
                        praznoPolje++;
                    }
                    Console.Write("*"); //zadnji znak je zvezdica
                }

                dolzina += (presezeno) * 2;

                Console.WriteLine();
            }
        }
    }

    class ParniZmaj:Karica
    {
        new public void Izris(int stevilo)
        {
            //če je vneseno število parno, ga zmanjšamo za 1
            if (stevilo % 2 == 0)
                stevilo -= 1;

            presezeno = 1; //ko karica preseže polovico izrisa            
            praznoPolje = (stevilo - 1) / 2; //pred začetkom karice
            dolzina = 1; //število zvezdic na začetku            

            string izpis = "";

            for (int i = 0; i < stevilo; i++) //število vrstic je enako vpisanemu številu
            {
                if (dolzina == stevilo)
                    presezeno = -1;

                Console.Write(izpis.PadLeft(praznoPolje, ' ')); //število praznih polj pred začetkom izrisa karice

                //karica 
                Console.Write("*"); //začetek vrstice v karici je vedno zvezdica

                int sredina = (stevilo + 1) / 2;
                int prostor = (dolzina - 3) / 2; //prostor med dvema zvezdicama

                if (i == 0 || i == stevilo - 1) //prva in zadnja vrstica se razlikujejo od ostalih
                    praznoPolje--;
                else if (i == sredina - 1) //srednja vrsta je drugačna od vseh, čisto polna zvezdic
                { 
                    Console.Write(izpis.PadLeft((dolzina - 1), '*')); //dolzina-1, ker je prva zvezdica že narisana
                    praznoPolje++;
                }
                else
                {
                    if (presezeno == 1)
                    {
                        Console.Write(izpis.PadLeft(prostor, ' '));
                        Console.Write("*");
                        Console.Write(izpis.PadLeft(prostor, ' '));
                        praznoPolje--;
                    }
                    else //presezeno == -1
                    {
                        Console.Write(izpis.PadLeft(prostor, ' '));
                        Console.Write("*");
                        Console.Write(izpis.PadLeft(prostor, ' '));
                        praznoPolje++;
                    }
                    Console.Write("*"); //zadnji znak je zvezdica
                }

                dolzina += (presezeno) * 2;

                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static int Vnos()
        {
            int stevilo = int.Parse(Console.ReadLine());
            return stevilo;
        }

        static int Meni()
        {
            Console.WriteLine();
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
            } while (izbira < 1 || izbira > 3);

            return izbira;
        }

        static void Main(string[] args)
        {
            int x = -1; //vnos dolžine
            int izbira = -1;
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

                //vpis oblike karice v primeru pravilnega vnosa velikosti
                if (x < 3 || x > 40)
                {
                    Console.WriteLine("Vneseno število je izven zahtevanih mej, ponovite ali vpisi 0 za izhod.");
                    Console.WriteLine();                    
                }                    
                else
                {
                    izbira = Meni();
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
