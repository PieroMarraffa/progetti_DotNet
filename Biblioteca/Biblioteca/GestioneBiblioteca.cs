using System;
namespace Biblioteca
{
    public class GestioneBiblioteca
    {
        public static Libro[] ricercaTitolo(Libro[] libri, string Titolo)
        {
            Titolo = Titolo.ToLower();
            if(libri.Length != 0)
            {
                Libro[] toReturn = new Libro[0];
                int i = 0;

                foreach (Libro item in libri)
                {
                    if (item.ricercaTitolo(Titolo) == true)
                    {
                        int k = 0;
                        Libro[] lista = new Libro[toReturn.Length + 1];
                        foreach(Libro item2 in toReturn)
                        {
                            lista.SetValue(item2, k);
                            k++;
                        }
                        lista.SetValue(item, toReturn.Length);
                        toReturn = lista;
                    }
                }

                return toReturn;
            }


            Libro[] nulla = new Libro[0];
            return nulla ;
        }

        public static Libro[] libriAutore(Libro[] libri, string Autore)
        {
            Autore = Autore.ToLower();
            if (libri.Length != 0)
            {
                Libro[] toReturn = new Libro[0];
                int i = 0;

                foreach (Libro item in libri)
                {
                    if (item.ricercaAutore(Autore) == true)
                    {
                        int k = 0;
                        Libro[] lista = new Libro[toReturn.Length + 1];
                        foreach (Libro item2 in toReturn)
                        {
                            lista.SetValue(item2, k);
                            k++;
                        }
                        lista.SetValue(item, toReturn.Length);
                        toReturn = lista;
                    }
                }
                return toReturn;
            }

            return libri;
        }



        public static int sceltaOpzione()
        {
            Console.WriteLine("DIGITA:");
            Console.WriteLine("1) PER AGGIUNGERE UN LIBRO");
            Console.WriteLine("2) PER CERCARE UN LIBRO DAL TITOLO");
            Console.WriteLine("3) PER CERCARE I LIBRI DI UN AUTORE");
            Console.WriteLine("0) PER USCIRE");

            int sceltaOpzioni = int.Parse(Console.ReadLine());

            while (sceltaOpzioni != 0 && sceltaOpzioni != 1 && sceltaOpzioni != 2 && sceltaOpzioni != 3)
            {
                Console.WriteLine("HAI INSERITO UN CODICE ERRATO");
                Console.WriteLine("DIGITA:");
                Console.WriteLine("1) PER AGGIUNGERE UN LIBRO");
                Console.WriteLine("2) PER CERCARE UN LIBRO DAL TITOLO");
                Console.WriteLine("3) PER CERCARE I LIBRI DI UN AUTORE");
                Console.WriteLine("0) PER USCIRE");
            }

            return sceltaOpzioni;
        }

        public static Libro[] inserisciLibro(Libro[] listaAttuale)
        {
            Console.WriteLine("");
            Console.WriteLine("Inserisci il titolo del libro o premi invio per tornare indietro");
            string titolo = Console.ReadLine().ToLower();

            if (titolo != "")
            {
                Console.WriteLine("");
                Console.WriteLine("inserisci il nome dell'autore");
                string autore = Console.ReadLine().ToLower();
                Console.WriteLine("");
                Console.WriteLine("inserisci il nome dell'editore");
                string editore = Console.ReadLine().ToLower();
                Console.WriteLine("");
                Console.WriteLine("inserisci l'anno di pubblicazione");
                int annoPubb = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("inserisci lo scaffale (IN NUMERI)");
                int scaffale = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("inserisci il piano (IN NUMERI)");
                int piano = int.Parse(Console.ReadLine());

                Libro libro = new Libro(titolo, autore, editore, annoPubb, scaffale, piano);

                Libro[] nuovaLista = new Libro[listaAttuale.Length + 1];

                if (listaAttuale.Length > 0)
                {
                    for (int i = 0; i < listaAttuale.Length; i++)
                    {
                        nuovaLista.SetValue(listaAttuale[i], i);
                    }
                }

                nuovaLista.SetValue(libro, listaAttuale.Length);

                return nuovaLista;
            }
            else return listaAttuale;
        }

        public static Libro[] InizializzaBiblio()
        {
            Libro[] libri = new Libro[4];
            libri.SetValue(new Libro("i promessi sposi", "manzoni", "bompiani", 1800, 1, 2), 0);
            libri.SetValue(new Libro("lettere al padre", "kafka", "mondadori", 1900, 2, 2), 1);
            libri.SetValue(new Libro("di nuovo promessi", "carofiglio", "adelchi", 2020, 2, 1), 2);
            libri.SetValue(new Libro("addio", "carofiglio", "adelchi", 2008, 1, 1), 3);

            return libri;
        }

        public static void ricercaLibroTitolo(Libro[] libri)
        {
            Console.WriteLine("");
            Console.WriteLine("Inserisci il titolo del libro che stai cercando o premi invio per tornare indietro");
            string titolo = Console.ReadLine();

            if(titolo != "")
            {
                Libro[] risultatoRicerca = ricercaTitolo(libri, titolo);
                if (risultatoRicerca.Length > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("LA RICERCA HA DATO I SUOI RISULTATI!");
                    foreach (Libro item in risultatoRicerca)
                    {
                        Console.WriteLine(item.toString());
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("LA RICERCA NON HA DATO I SUOI RISULTATI!");
                }
            }
        }

        public static void ricercaLibriAutori(Libro[] libri)
        {
            Console.WriteLine("");
            Console.WriteLine("Inserisci il titolo del libro che stai cercando o premi invio per tornare indietro");
            string autore = Console.ReadLine();

            if (autore != "")
            {
                Libro[] risultatoRicerca = libriAutore(libri, autore);
                if (risultatoRicerca.Length > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("LA RICERCA HA DATO I SUOI RISULTATI!");
                    foreach (Libro item in risultatoRicerca)
                    {
                        Console.WriteLine(item.toString());
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("LA RICERCA NON HA DATO I SUOI RISULTATI!");
                }
            }
        }
    }
}
