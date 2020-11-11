using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja___Karica_2.del
{
    class ParniZmaj : Karica
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
}
