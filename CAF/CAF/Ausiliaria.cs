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

        public static int sceltaIn()
        {
            Console.WriteLine("BENVENUTO!!!");
            Console.WriteLine("DIGITA: ");
            Console.WriteLine("1 per accedere al servizio");
            Console.WriteLine("2 per uscire");
            int sceltaIniziale = int.Parse(Console.ReadLine());
            return sceltaIniziale;
        }

        public static int sceltaOp()
        {
            Console.WriteLine("");
            Console.WriteLine("SCEGLI L'OPERZIONE DA ESEGUIRE");
            Console.WriteLine("1 verifica il diritto al REDDITO DI CITTADINANZA");
            Console.WriteLine("2 verifica il diritto a QUOTA 100");
            Console.WriteLine("3 calcola la tassazione IRPEF");
            Console.WriteLine("4 stima il tuo attuale DISSIDIO DI DISOCCUPAZIONE");
            Console.WriteLine("0 ESCI");
            int sceltaOperazione = int.Parse(Console.ReadLine());
            return sceltaOperazione;
        }

        public static void reddito(Person utente)
        {
            RedditoDiCittadinanza redditoDiCittadinanza = new RedditoDiCittadinanza(utente);
            if (redditoDiCittadinanza.verificaDiritto() == true)
            {
                Console.WriteLine("Complimenti!!! Hai diritto al  REDDITO DI CITTADINANZA");
            }
            else
            {
                Console.WriteLine("Ci dispiace! NON hai diritto al  REDDITO DI CITTADINANZA");
            }
        }

        public static void quota100(Person utente)
        {
            Quota100 quota100 = new Quota100(utente);
            if (quota100.verificaDiritto() == true)
            {
                Console.WriteLine("Complimenti!!! Hai diritto a QUOTA100");
            }
            else
            {
                Console.WriteLine("Ci dispiace! NON hai diritto a QUOTA100");
                Console.WriteLine("Per averne diritto mancano: " + quota100.calcoloAnniMancantiAttivi().ToString() + " anni di attività");
                Console.WriteLine("oppure: " + quota100.calcoloAnniMancantiPassivi().ToString() + " anni di passività");
            }
        }

        public static void irpeff(Person utente)
        {
            CalcoloIrpeff irpeff = new CalcoloIrpeff(utente);
            Console.WriteLine("La tua attuale tassazione IRPEFF ammonta a: " + irpeff.calcoloTassazione().ToString() + " euro");
        }

        public static void naspi(Person utente)
        {
            Naspi naspi = new Naspi(utente);
            if (naspi.verificaDiritto() == true)
            {
                Console.WriteLine("Il tuo attuale sussidio di disoccupazione ammonta a: " + naspi.calcoloAmmontare());
            }
            else
            {
                Console.WriteLine("Ci dispiace, ma al momento NON hai diritto al SUSSIDIO DI DISOCCUPAZIONE");
            }
        }
    }
}
