using System;
using System.Collections.Generic;

namespace Cellulari
{
    class MainClass
    {
        private static List<Cellulare> cellulari;
        private static DB db;

        public static void Main(string[] args)
        {
            Console.WriteLine("BEMVENUTO!!!");
            inizio();
        }

        public static void inizio()
        {

            db = new DB("Cellulari");
            db.openDB();

            cellulari = db.getCellulari();

            Console.WriteLine("");
            Console.WriteLine("COSA VUOI FARE?");
            Console.WriteLine("1) VISUALIZZA I CELLULARI NELLO STORE");
            Console.WriteLine("2) VISUALIZZA I CELLULARI NELLO STORE PER FASCIA DI PREZZO");
            Console.WriteLine("3) VISUALIZZA I CELLULARI PER MARCA");
            Console.WriteLine("4) VENDI CELLULARE");
            Console.WriteLine("5) ESCI");

            try
            {
                int primaScelta = int.Parse(Console.ReadLine());

                switch (primaScelta)
                {
                    case 1:
                        {
                            visualizzaCell();
                        };
                        break;
                    case 2:
                        {
                            visualizzaCellPerFascia();
                        };
                        break;
                    case 3:
                        {
                            visualizzaCellPerMarca();
                        };
                        break;
                    case 4:
                        {
                            vendi();
                        };
                        break;
                    case 5:
                        {
                            Console.WriteLine("");
                            Console.WriteLine(("ARRIVEDERCI!").ToUpper());
                            Uscita();
                        };
                        break;
                    default:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("IL CODICE INSERITO NON È VALIDO");
                            inizio();
                        };
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine(("il codice inserito non è valido").ToUpper());
                inizio();
            }

        }

        public static void visualizzaCell()
        {
            Console.WriteLine("");
            Console.WriteLine("CELLULARI IN MAGAZZINO: ");
            foreach (var item in cellulari)
            {
                Console.WriteLine(item.toString());
            }
            inizio();
        }

        public static void visualizzaCellPerFascia()
        {
            Console.WriteLine("");
            Console.WriteLine("INSERISCI IL PREZZO LIMITE BASSO: ");
            try
            {
                int basso = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("INSERISCI IL PREZZO LIMITE ALTO: ");
                try
                {
                    int alto = int.Parse(Console.ReadLine());

                    //List<Cellulare> fasciaDiPrezzo = from cel in cellulari where cel > basso && cel < alto select cel;
                    List<Cellulare> fasciaDiPrezzo = new List<Cellulare>();

                    foreach (var cel in cellulari)
                    {
                        if (cel.getPrezzo() >= basso && cel.getPrezzo() <= alto)
                        {
                            fasciaDiPrezzo.Add(cel);
                        }
                    }

                    foreach (var cel in fasciaDiPrezzo)
                    {
                        Console.WriteLine(cel.toString());
                    }

                    inizio();
                }
                catch (FormatException)
                {
                    Console.WriteLine("");
                    Console.WriteLine("IL CODICE INSERITO NON È VALIDO");
                    inizio();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine("IL CODICE INSERITO NON È VALIDO");
                inizio();
            }
        }

        public static void visualizzaCellPerMarca()
        {
            Console.WriteLine("");
            Console.WriteLine("SCEGLI LA MARCA: ");
            List<string> marche = new List<string>();
            marche.Add(cellulari[0].getMarca());
            foreach (var item in cellulari)
            {
                bool add = true;
                foreach(var str in marche)
                {
                    if (item.getMarca().Equals(str) == true)
                    {
                        add = false;
                    }
                }
                if (add)
                {
                    marche.Add(item.getMarca());
                }
            }

            int i = 0;
            foreach(var str in marche)
            {
                Console.WriteLine($"{i}) {str}");
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("SCEGLI LA MARCA");
            try
            {
                int marchetta = int.Parse(Console.ReadLine());
                if(marchetta >= i)
                {
                    Console.WriteLine("");
                    Console.WriteLine("IL CODICE INSERITO NON È RICONOSCIUTO");
                    inizio();
                }
                else
                {
                    string marcaSelezionata =  marche[marchetta];
                    Console.WriteLine("");
                    Console.WriteLine("CELLULARI IN MAGAZZINO DI MARCA: " + marcaSelezionata + ":");

                    foreach(var item in cellulari)
                    {
                        if (item.getMarca().Equals(marcaSelezionata))
                        {
                            Console.WriteLine(item.toString());
                        }
                    }
                }
                inizio();
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("IL CODICE INSERITO NON È RICONOSCIUTO");
                inizio();
            }
            inizio();
        }

        public static void vendi()
        {
            Console.WriteLine("");
            Console.WriteLine("INSERISCI LA MARCA");
            string marca = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("INSERISCI IL MODELLO");
            string modello = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("INSERISCI IL PREZZO");
            try
            {
                double prezzo = double.Parse(Console.ReadLine());
                Cellulare cel = new Cellulare(marca, modello, prezzo);
                db.insertCell(cel);
                inizio();
            }
            catch (FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine("IL CODICE INSERITO NON È VALIDO");
                inizio();
            }
        }

        public static void Uscita()
        {
            db.closeDB();
        }
    }
}
