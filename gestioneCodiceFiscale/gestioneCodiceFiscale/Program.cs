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
            while (cod.goodLenght() != true)
            {
                Console.WriteLine("ATTENZIONE LUNGHEZZA ERRATA!!!");
                Console.WriteLine("Reinserisci il tuo codice fiscale: ");
                cf = Console.ReadLine();
                cod.setCodFiscale(cf);
            }


            string date = cod.getBirthDate();
            Console.WriteLine("la data di nascita è: " + date);
            string age = cod.getAge();
            Console.WriteLine("l'età è: " + age);
            string gender = cod.getGender();
            Console.WriteLine("il genere è: " + gender);

        }
    }
}
