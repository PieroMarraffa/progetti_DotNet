using System;
namespace CAF
{
    public class Ausiliaria
    {
        public Ausiliaria()
        {
        }

        public static Person accesso()
        {
            Console.WriteLine("");
            Console.WriteLine("inserisci il tuo NOME");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("inserisci il tuo COGNOME");
            string cognome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("inserisci il tuo SESSO");
            string sesso = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("inserisci la tua ETÀ");
            int eta = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("inserisci i tuoi anni lavorativi totali");
            int anniLavorativiTotali = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("inserisci i tuoi anni lavorativi dell'ultima occupazione");
            int anniLavorativiTotaliUltimaOccupazione = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("inserisci il tuo ISEE");
            double isee = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("inserisci il tuo PATRIMONIO IMMOBILIARE");
            double patrimonioImmobiliare = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("inserisci il tuo REDDITO ANNUALE");
            double redditoAnnuale = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("inserisci il VALORE DELLA TUA ULTIMA BUSTA PAGA");
            double ultimaBustaPagaNetta = double.Parse(Console.ReadLine());

            Person utente = new Person(nome, cognome, sesso, eta, anniLavorativiTotali, anniLavorativiTotaliUltimaOccupazione, isee, patrimonioImmobiliare, redditoAnnuale, ultimaBustaPagaNetta);

            return utente;
        }
    }
}
