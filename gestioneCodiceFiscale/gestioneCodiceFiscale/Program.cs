using System;

namespace gestioneCodiceFiscale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo codice fiscale: ");
            string cf = Console.ReadLine();

            codFiscale cod = new codFiscale(cf);
            while(cod.goodLenght() != true)
            {
                Console.WriteLine("ATTENZIONE LUNGHEZZA ERRATA!!!");
                Console.WriteLine("Reinserisci il tuo codice fiscale: ");
                cf = Console.ReadLine();
                cod.setCodFiscale(cf);
            }

            cod.getBirthDate();

        }
    }
}
