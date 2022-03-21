using System;

namespace CAF
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person utente = new Person("Piero", "Marraffa", "Maschio", 22, 1, 1, 16000, 28000, 19000, 1500);

            
            int sceltaIniziale = Ausiliaria.sceltaIn();

            Console.WriteLine("");
            Console.WriteLine("HAI DIGITATO " + sceltaIniziale);
            Console.WriteLine("");

            while (sceltaIniziale != 1 && sceltaIniziale != 2)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE ERRATO");
                Console.WriteLine("");
                sceltaIniziale = Ausiliaria.sceltaIn();
            }

            if(sceltaIniziale == 1)
            {

                Person utente = new Person();

                utente = Ausiliaria.accesso();

                Console.WriteLine("BENVENUTO " + utente.getNome() + " !!!");
                
                int uscita = 0;

                while (uscita != 1)
                {

                    int sceltaOperazione = Ausiliaria.sceltaOp();

                    while (sceltaOperazione != 1 && sceltaOperazione != 2 && sceltaOperazione != 3 && sceltaOperazione != 4 && sceltaOperazione != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("HAI INSERITO UN CODICE ERRATO");
                        sceltaOperazione = Ausiliaria.sceltaOp();
                    }

                    switch (sceltaOperazione)
                    {
                        case 1:
                            {
                                Ausiliaria.reddito(utente);
                            };
                            break;

                        case 2:
                            {
                                Ausiliaria.quota100(utente);
                            };
                            break;

                        case 3:
                            {
                                Ausiliaria.irpeff(utente);
                            };
                            break;

                        case 4:
                            {
                                Ausiliaria.naspi(utente);
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
