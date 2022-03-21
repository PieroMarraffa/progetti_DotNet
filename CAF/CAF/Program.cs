using System;

namespace CAF
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person utente = new Person("Piero", "Marraffa", "Maschio", 22, 1, 1, 16000, 28000, 19000, 1500);

            Console.WriteLine("BENVENUTO!!!");
            Console.WriteLine("DEGITA: ");
            Console.WriteLine("1 per accedere al servizio");
            Console.WriteLine("2 per uscire");
            int sceltaIniziale = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("HAI DIGITATO " + sceltaIniziale);
            Console.WriteLine("");

            while (sceltaIniziale != 1 && sceltaIniziale != 2)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE ERRATO");
                Console.WriteLine("");
                Console.WriteLine("DEGITA: ");
                Console.WriteLine("1 per accedere al servizio");
                Console.WriteLine("2 per uscire");
                sceltaIniziale = int.Parse(Console.ReadLine());
            }

            if(sceltaIniziale == 1)
            {

                //Person utente = new Person("Piero", "Marraffa", "Maschio", 22, 1, 1, 16000, 28000, 19000, 1500);
                Person utente = new Person();

                utente = Ausiliaria.accesso();

                Console.WriteLine("BENVENUTO " + utente.getNome() + " !!!");
                
                int uscita = 0;

                while (uscita != 1)
                {

                    Console.WriteLine("");
                    Console.WriteLine("SCEGLI L'OPERZIONE DA ESEGUIRE");
                    Console.WriteLine("1 verifica il diritto al REDDITO DI CITTADINANZA");
                    Console.WriteLine("2 verifica il diritto a QUOTA 100");
                    Console.WriteLine("3 calcola la tassazione IRPEF");
                    Console.WriteLine("4 stima il tuo attuale DISSIDIO DI DISOCCUPAZIONE");
                    Console.WriteLine("0 ESCI");
                    int sceltaOperazione = int.Parse(Console.ReadLine());

                    while (sceltaOperazione != 1 && sceltaOperazione != 2 && sceltaOperazione != 3 && sceltaOperazione != 4 && sceltaOperazione != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("HAI INSERITO UN CODICE ERRATO");
                        Console.WriteLine("");
                        Console.WriteLine("SCEGLI L'OPERZIONE DA ESEGUIRE");
                        Console.WriteLine("1 verifica il diritto al REDDITO DI CITTADINANZA");
                        Console.WriteLine("2 verifica il diritto a QUOTA 100");
                        Console.WriteLine("3 calcola la tassazione IRPEF");
                        Console.WriteLine("4 stima il tuo attuale DISSIDIO DI DISOCCUPAZIONE");
                        Console.WriteLine("0 ESCI");
                        sceltaOperazione = int.Parse(Console.ReadLine());
                    }

                    switch (sceltaOperazione)
                    {
                        case 1:
                            {
                                RedditoDiCittadinanza redditoDiCittadinanza = new RedditoDiCittadinanza(utente);
                                if(redditoDiCittadinanza.verificaDiritto() == true)
                                {
                                    Console.WriteLine("Complimenti!!! Hai diritto al  REDDITO DI CITTADINANZA");
                                }
                                else
                                {
                                    Console.WriteLine("Ci dispiace! NON hai diritto al  REDDITO DI CITTADINANZA");
                                }
                            };
                            break;

                        case 2:
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
                            };
                            break;

                        case 3:
                            {
                                CalcoloIrpeff irpeff = new CalcoloIrpeff(utente);
                                Console.WriteLine("La tua attuale tassazione IRPEFF ammonta a: " + irpeff.calcoloTassazione().ToString() + " euro");
                            };
                            break;

                        case 4:
                            {
                                Naspi naspi = new Naspi(utente);
                                if(naspi.verificaDiritto() == true)
                                {
                                    Console.WriteLine("Il tuo attuale sussidio di disoccupazione ammonta a: " + naspi.calcoloAmmontare());
                                }
                                else
                                {
                                    Console.WriteLine("Ci dispiace, ma al momento NON hai diritto al SUSSIDIO DI DISOCCUPAZIONE");
                                }
                            };
                            break;

                        case 0: uscita = 1;
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("ARRIVEDERCI !!!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ARRIVEDERCI !!!");
            }
        }
    }
}
