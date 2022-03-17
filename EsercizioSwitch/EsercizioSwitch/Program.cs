using System;

namespace EsercizioSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            int scelta;
            Console.WriteLine("Inserisci 1 per l'addizione");
            Console.WriteLine("Inserisci 2 per la sottrazione");
            Console.WriteLine("Inserisci 3 per il prodotto");
            Console.WriteLine("Inserisci 4 per il rapporto");
            Console.WriteLine("Inserisci 0 per l'addizione");
            scelta = int.Parse(Console.ReadLine());

            while (scelta != 0)
            {

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("hai scelto" + scelta);
                        break;
                    case 2:
                        Console.WriteLine("hai scelto" + scelta);
                        break;
                    case 3:
                        Console.WriteLine("hai scelto" + scelta);
                        break;
                    case 4:
                        Console.WriteLine("hai scelto" + scelta);
                        break;
                    case 0:
                        Console.WriteLine("hai scelto" + scelta);
                        break;
                }

                Console.WriteLine("Inserisci 1 per l'addizione");
                Console.WriteLine("Inserisci 2 per la sottrazione");
                Console.WriteLine("Inserisci 3 per il prodotto");
                Console.WriteLine("Inserisci 4 per il rapporto");
                Console.WriteLine("Inserisci 0 per l'addizione");
                scelta = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("GRAZIE E ARRIVEDERCI");
        }
    }
}
