using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja___Karica_2.del
{
    class ObrobaKarice : Karica
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
}
