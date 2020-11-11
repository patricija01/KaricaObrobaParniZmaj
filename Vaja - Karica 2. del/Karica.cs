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
}
