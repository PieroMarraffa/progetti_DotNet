using System;
using System.Collections;
using System.Collections.Generic;
namespace Veicoli
{
    public class Ausiliaria
    {

        public static List<AutoCarro> creaAutocarro(List<AutoCarro> lista)
        {
            Console.WriteLine("");
            Console.WriteLine("IN QUESTO MENU PUOI INSERIRE UN AUTOCARRO");
            Console.WriteLine("INSERISCI LA TARGA O PREMI INVIO PER TORNARE INDIETRO");
            string targa = Console.ReadLine();
            if (targa == "")
            {
                return lista;
            }
            else
            {
                while(verificaEsistenza(lista, targa) == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("LA TARGA INSERITA È GIÀ PRESENTE NEL SISTEMA");
                    Console.WriteLine("INSERISCI LA TARGA O PREMI INVIO PER TORNARE INDIETRO");
                    targa = Console.ReadLine();
                    if (targa == "")
                    {
                        return lista;
                    }
                }
                Console.WriteLine("INSERISCI LA MARCA DEL VEICOLO");
                string marca = Console.ReadLine();
                Console.WriteLine("INSERISCI IL MODELLO DEL VEICOLO");
                string modello = Console.ReadLine();
                Console.WriteLine("INSERISCI IL NUMERO DI POSTI DEL VEICOLO");
                int nPosti = int.Parse(Console.ReadLine());
                Console.WriteLine("INSERISCI LA CAPACITÀ MASSIMA DEL VEICOLO");
                int capacita = int.Parse(Console.ReadLine());

                AutoCarro carro = new AutoCarro(targa, marca, modello, nPosti, capacita);
                lista.Add(carro);

                return lista;
            }
        }

        private static bool verificaEsistenza(List<AutoCarro> lista, string targa)
        {
            foreach (AutoCarro item in lista)
            {
                if (targa.Equals(item.getTarga()))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public static List<AutoVeicolo> creaVeicolo(List<AutoVeicolo> lista)
        {
            Console.WriteLine("");
            Console.WriteLine("IN QUESTO MENU PUOI INSERIRE UN AUTOCARRO");
            Console.WriteLine("INSERISCI LA TARGA O PREMI INVIO PER TORNARE INDIETRO");
            string targa = Console.ReadLine();
            if (targa == "")
            {
                return lista;
            }
            else
            {
                while (verificaEsistenza(lista, targa) == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("LA TARGA INSERITA È GIÀ PRESENTE NEL SISTEMA");
                    Console.WriteLine("INSERISCI LA TARGA O PREMI INVIO PER TORNARE INDIETRO");
                    targa = Console.ReadLine();
                    if (targa == "")
                    {
                        return lista;
                    }
                }
                Console.WriteLine("INSERISCI LA MARCA DEL VEICOLO");
                string marca = Console.ReadLine();
                Console.WriteLine("INSERISCI IL MODELLO DEL VEICOLO");
                string modello = Console.ReadLine();
                Console.WriteLine("INSERISCI IL NUMERO DI POSTI DEL VEICOLO");
                int nPosti = int.Parse(Console.ReadLine());
                Console.WriteLine("INSERISCI LA CAPACITÀ MASSIMA DEL VEICOLO");
                int nPorte = int.Parse(Console.ReadLine());

                AutoVeicolo veicolo = new AutoVeicolo(targa, marca, modello, nPosti, nPorte);
                lista.Add(veicolo);

                return lista;
            }
        }

        private static bool verificaEsistenza(List<AutoVeicolo> lista, string targa)
        {
            foreach (AutoVeicolo item in lista)
            {
                if (targa.Equals(item.getTarga()))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
    }
}
