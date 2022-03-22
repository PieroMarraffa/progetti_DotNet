using System;

namespace TeatroArcobaleno
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedile[] postiTeatro = Ausiliaria.inizializzaTeatro();

            int sceltaOpzione = 6;

            while (sceltaOpzione != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("BENVENUTO AL TEATRO ARCOBALENO !!!");
                sceltaOpzione = Ausiliaria.sceltaOpzione();
                while (sceltaOpzione != 0 && sceltaOpzione != 1 && sceltaOpzione != 2 && sceltaOpzione != 3 && sceltaOpzione != 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("HAI DIGITATO UN CODICE NON RICONOSCIUTO");
                    sceltaOpzione = Ausiliaria.sceltaOpzione();
                }

                switch (sceltaOpzione)
                {
                    case 0:;
                        break;
                    case 1:
                        {
                            postiTeatro = Ausiliaria.prenotazione(postiTeatro);
                        };
                        break;
                    case 2:
                        {
                            Ausiliaria.visualizzaPosti(postiTeatro);
                            Ausiliaria.prenotazioneInterfaccia(postiTeatro);
                        };
                        break;
                    case 3:
                        Ausiliaria.visualizzaPosti(postiTeatro);
                        break;
                    case 4: Ausiliaria.annullaPrenotazione(postiTeatro);
                        break;
                }

            }
        }
    }
}
