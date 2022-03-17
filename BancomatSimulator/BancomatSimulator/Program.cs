using System;

namespace BancomatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            gestioneBancomat bancomat = new gestioneBancomat(1500, 1234);

            Console.WriteLine("BENVENUTO NEL NOSTRO SISTEMA DI BANCOMAT");
            Console.WriteLine("inserisci il PIN per accedere al tuo conto");

            int tentativi = 0;
            bool access = bancomat.verifyAccess(int.Parse(Console.ReadLine()));
            tentativi++;
            while (access != true && tentativi < 3)
            {
                Console.WriteLine("IL PIN INSERITO È ERRATO");
                Console.WriteLine("");
                Console.WriteLine("!!! ATTENZINE TI RESTANO SOLO " + (3 - tentativi).ToString() + " TENTATIVI !!!");
                Console.WriteLine("");
                Console.WriteLine("inserisci il PIN per accedere al tuo conto");
                access = bancomat.verifyAccess(int.Parse(Console.ReadLine()));
                tentativi++;
            }

            if(access == true)
            {
            bool accessed = true;
            Console.WriteLine("BENTORNATO!");
            while (accessed == true)
            {

                Console.WriteLine("INSERISCI 1 PER VERIFICARE LA DISPONIBILITÀ DEL CONTO");
                Console.WriteLine("INSERISCI 2 PER EFFETTUARE UN PRELIEVO");
                Console.WriteLine("INSERISCI 3 PER EFFETTUARE UN VERSAMENTO");
                Console.WriteLine("INSERISCI 0 PER USCIRE DAL CONTO");
                Console.WriteLine("");
                int scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("il tuo conto è pari a: " + bancomat.getConto().ToString());
                        Console.WriteLine("");
                        break;
                    case 2:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("inserisci l'ammontare del prelievo");
                            int amount = int.Parse(Console.ReadLine());
                            int success = bancomat.withdraw(amount);
                            if (success == 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("PRELIEVO ANDATO A BUON FINE");
                                Console.WriteLine("");
                            }
                            else if(success == 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("HAI INSERITO UNA SOMMA SUPERIORE AL TUO CONTO ATTUALE");
                                Console.WriteLine("");
                            }
                            else if(success == 2)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("HAI INSERITO UNA SOMMA SUPERIORE AL LIMITE CONSENTITO");
                                    Console.WriteLine("");
                                }
                        };
                        break;
                    case 3:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("inserisci l'ammontare del versamento");
                            int amount = int.Parse(Console.ReadLine());
                            bancomat.deposit(amount);
                            Console.WriteLine("");
                            Console.WriteLine("HAI DEPOSITATO " + amount.ToString() + " EURO");
                            Console.WriteLine("");
                        };
                        break;
                    case 0:
                        accessed = false;
                        break;
                    default:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("IL CODICE OPERATIVO INSERITO È ERRATO");
                            Console.WriteLine("");
                        }
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("ARRIVEDERCI!!");
            Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("IL CONTO È BLOCCATO!!!");
                Console.WriteLine("");
            }
        }
    }
}
