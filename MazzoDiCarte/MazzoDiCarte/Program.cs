using System;
using System.Collections.Generic;

namespace MazzoDiCarte
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mazzo mazzo = new Mazzo();
            mazzo.costruisciMazzo();
            Console.WriteLine("BENVENUTO AL TAVOLO");
            Console.WriteLine("STAI GIOCANDO CONTRO IL BANCO");
            Console.WriteLine("");
            Console.WriteLine("MANO DEL BANCO: ");
            List<Carta> manoDelBanco = new List<Carta>();
            for (int i  = 0; i < 5; i++)
            {
                Carta aggiunta = new Carta();
                aggiunta = mazzo.estraiCarta();
                manoDelBanco.Add(aggiunta);
                Console.WriteLine(aggiunta.toString());
            }
            Console.WriteLine("");
            Console.WriteLine("MANO DEL BANCO: ");
            List<Carta> manoDelGiocatore = new List<Carta>();
            for (int i = 0; i < 5; i++)
            {
                Carta aggiunta = new Carta();
                aggiunta = mazzo.estraiCarta();
                manoDelGiocatore.Add(aggiunta);
                Console.WriteLine(aggiunta.toString());
            }

            //MOSTRA LE CARTE RIMASTE
            /*
            Console.WriteLine("");
            Console.WriteLine("CARTE RIMASTE: ");
            foreach (var item in mazzo)
            {
                Console.WriteLine(item.toString());
            }
            */
        }
    }
}
