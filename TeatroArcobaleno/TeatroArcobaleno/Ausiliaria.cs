using System;
namespace TeatroArcobaleno
{
    public class Ausiliaria
    {

        public static int sceltaOpzione()
        {
            Console.WriteLine("");
            Console.WriteLine("SCEGLI UN CODICE PER ESEGUIRE UN'OPZIONE");
            Console.WriteLine("1) PRENOTAZIONE POSTI SEQUENZIALE AUTOMATICA");
            Console.WriteLine("2) PRENOTAZIONE POSTI DA INTERFACCIA");
            Console.WriteLine("3) VISUALIZZA LA SALA");
            Console.WriteLine("4) ANNULLA PRENOTAZIONE");
            Console.WriteLine("0) ESCI");
            int sceltaOpzione = int.Parse(Console.ReadLine());

            return sceltaOpzione;
        }

        public static Sedile[] inizializzaTeatro()
        {

            Sedile[] postiTeatro = new Sedile[50];
            int posizione = 0;

            for(int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 10; j++)
                {

                    Sedile sedile = new Sedile(new Persona("", "", -1), i, j);
                    postiTeatro.SetValue(sedile, posizione);
                    posizione++;

                }
            }

            return postiTeatro;
        }

        public static Sedile[] prenotazione(Sedile[] posti)
        {
            Console.WriteLine("");
            Console.WriteLine("MENU PRENOTAZIONE");
            Console.WriteLine("DIGITA IL NUMERO DI POSTI DA PRENOTARE (max 10) O PREMI INVIO PER TORNARE INDIETRO");
            string prenotazione = Console.ReadLine();
            while (prenotazione != "" && (int.Parse(prenotazione) > 10 && int.Parse(prenotazione) < 1)){
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                Console.WriteLine("DIGITA IL NUMERO DI POSTI DA PRENOTARE (max 10) O PREMI INVIO PER TORNARE INDIETRO");
                prenotazione = Console.ReadLine();
            }
            if (prenotazione == "")
            {
                return posti;
            }
            else
            {
                var (esito, sedili) = checkPrenotazione(posti, int.Parse(prenotazione));
                if (esito == true)
                {
                    Console.WriteLine("La prenotazione è andata a buon fine");
                    return sedili;
                }
                else
                {
                    Console.WriteLine("NON è stato possibile eseguire questa prenotazione. Prova con quella da interfaccia");
                    return posti;
                }
            }
        }

        public static (bool, Sedile[]) checkPrenotazione(Sedile[] posti, int prenotati)
        {
            foreach(Sedile item in posti)
            {
                if (sedileVuoto(item) == true)
                {
                    Sedile[] adiacenti = getAdiacenti(posti, item, prenotati);
                    if (adiacenti.Length != 0)
                    {
                        bool prenotabile = true;
                        foreach(Sedile sedile in adiacenti)
                        {
                            if (sedileVuoto(sedile) == false)
                            {
                                prenotabile = false;
                            }
                        }
                        if (prenotabile == true)
                        {
                            posti = effettuaPrenotazione(posti, item, prenotati);
                            return (true, posti);
                        }
                    }
                }
            }
            return (false, posti);
        }

        public static bool sedileVuoto(Sedile sedile)
        {
            Persona p = sedile.getPersona();
            if (p.getNome() == "" && p.getCognome() == "" && p.getEta() == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Sedile[] getAdiacenti(Sedile[] posti,Sedile posto, int numero)
        {
            Sedile[] adiacenti = new Sedile[numero];
            if (posto.getColonna() + numero <= 11)
            {
                for (int i = 0; i < numero; i++)
                {
                    adiacenti.SetValue(posti[(posto.getColonna() + i - 1) + ((posto.getFila() - 1) * 10)], i);
                }
                return adiacenti;
            }
            else return (new Sedile[0]);
        }

        private static Sedile[] effettuaPrenotazione(Sedile[] posti, Sedile primoSedile, int quantità)
        {
            Console.WriteLine("");
            Console.WriteLine("SEI IN FASE DI PRENOTAZIONE.");
            Console.WriteLine("INSERISCI IL NOME");
            string nome = Console.ReadLine();
            Console.WriteLine("INSERISCI IL COGNOME");
            string cognome = Console.ReadLine();
            Console.WriteLine("INSERISCI L'ETÀ IN NUMERI");
            int eta = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantità; i++)
            {
                posti.SetValue(new Sedile(new Persona(nome, cognome, eta), primoSedile.getFila(), (primoSedile.getColonna()) + i), ((primoSedile.getColonna() - 1) + ((primoSedile.getFila() - 1) * 10) + i));
            }
            return posti;
        }



        public static void visualizzaPosti(Sedile[] posti)
        {
            for(int j = 0; j < 5; j++)
            {
                string line = "";
                for (int i = 0; i < 10; i++)
                {
                    if (sedileVuoto(posti[i + (j * 10)]) == false)
                        line = line + " occ" + " ";
                    else
                        line = line + " _" + (i + 1 + (j * 10)) + "_ ";
                }
                Console.WriteLine(line);
            }
        }

        public static Sedile[] prenotazioneInterfaccia(Sedile[] posti)
        {
            int numMax = getNumeroPostiLiberi(posti);

            Console.WriteLine("");
            Console.WriteLine("DIGITA IL NUMERO DI POSTI DA PRENOTARE (max " + numMax + ") O PREMI INVIO PER TORNARE INDIETRO");
            string valore = Console.ReadLine();
            if(valore == "")
            {
                return posti;
            }
            int posto = int.Parse(valore);
            while (posto > numMax)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN NUMERO DI POSTI TROPPO ALTO");
                Console.WriteLine("DIGITA IL NUMERO DI POSTI DA PRENOTARE (max " + numMax + ") O PREMI INVIO PER TORNARE INDIETRO");
                valore = Console.ReadLine();
                if (valore == "")
                {
                    return posti;
                }
                posto = int.Parse(valore);
            }

            for (int i = 0; i < posto; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("INSERISCI IL CODICE DEL POSTO DA PRENOTARE");
                int posizione = int.Parse(Console.ReadLine());
                Console.WriteLine(sedileVuoto(posti[posizione - 1]));
                while (posizione > 50 || posizione < 1 || sedileVuoto(posti[posizione - 1]) == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("IL CODICE INSERITO È NON VALIDO O IL POSTO È PIENO");
                    Console.WriteLine("INSERISCI IL CODICE DEL POSTO DA PRENOTARE");
                    posizione = int.Parse(Console.ReadLine());
                }

                posti = effettuaPrenotazione(posti, posti[posizione - 1], 1);
            }
            return posti;
        }

        public static int getNumeroPostiLiberi(Sedile[] sedili)
        {
            int i = 0;
            foreach(Sedile item in sedili)
            {
                if (sedileVuoto(item) == true)
                {
                    i++;
                }
            }
            return i;
        }

        public static Sedile[] annullaPrenotazione(Sedile[] posti)
        {
            Console.WriteLine("");
            Console.WriteLine("SEI IN FASE DI ANNULLAMENTO PRENOTAZIONE.");
            Console.WriteLine("INSERISCI IL TUO NOME");
            string nome = Console.ReadLine();
            Console.WriteLine("INSERISCI IL TUO COGNOME");
            string cognome = Console.ReadLine();
            Console.WriteLine("INSERISCI L'ETÀ IN NUMERI");
            int eta = int.Parse(Console.ReadLine());

            foreach(Sedile sedile in posti)
            {
                if(sedile.getPersona().getNome().Equals(nome) && sedile.getPersona().getCognome().Equals(cognome) && sedile.getPersona().getEta() == eta)
                {
                    sedile.setSedileVuoto();
                }
            }

            return posti;
        }
    }
}
