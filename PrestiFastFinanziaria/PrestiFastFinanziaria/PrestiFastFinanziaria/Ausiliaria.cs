using System;
using System.Collections.Generic;
namespace PrestiFastFinanziaria
{
    public class Ausiliaria
    {
        private static Persona persona = new Persona();
        private static DB db = new DB("PrestFast");

        public static void benvenuto()
        {
            db.openDB();
            Console.WriteLine("BENVENUTO!!");
            Console.WriteLine("");
            Console.WriteLine("DIGITA:");
            Console.WriteLine("1) PER ESEGUIRE IL LOGIN");
            Console.WriteLine("2) PER REGISTRARTI");
            try
            {
                int scelta = int.Parse(Console.ReadLine());

                if (scelta == 1)
                {
                    Login();
                }
                else if (scelta == 2)
                {
                    SignUp();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO:");
                    benvenuto();
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO:");
                benvenuto();
            }
        }

        private static void Login()
        {
            Console.WriteLine("STAI ESEGUENDO IL LOGIN!!");
            Console.WriteLine("");
            Console.WriteLine("DIGITA:");
            Console.WriteLine("1) PER CONTINUARE");
            Console.WriteLine("QUALUNQUE ALTRO TASTO PER TORNARE INDIETRO");
            try
            {
                int scelta = int.Parse(Console.ReadLine());
                if (scelta == 1)
                {
                    Console.WriteLine("INSERISCI IL TUO CODICE FISCALE");
                    string cf = Console.ReadLine().ToUpper();
                    if (db.getPersonaFromCF(cf).Item2 == true)
                    {
                        persona = db.getPersonaFromCF(cf).Item1;
                        if (cf.Equals("ADMINCOMANDANTE0"))
                        {
                            primaPaginaAdmin();
                        }
                        else primaPagina();
                    }
                    else
                    {
                        Console.WriteLine("NEL DB NON SONO PRESENTI PROFILI CON QUESTO CF. RITENTA O REGISTRATI");
                        benvenuto();
                    }
                }
            }
            catch (FormatException fe)
            {
                benvenuto();
            }
        }

        private static void SignUp()
        {
            Console.WriteLine("STAI ESEGUENDO LA REGISTRAZIONE!!");
            Console.WriteLine("");
            Console.WriteLine("DIGITA:");
            Console.WriteLine("1) PER CONTINUARE");
            Console.WriteLine("QUALUNQUE ALTRO TASTO PER TORNARE INDIETRO");
            try
            {
                int scelta = int.Parse(Console.ReadLine());
                if (scelta == 1)
                {
                    Console.WriteLine("INSERISCI IL TUO NOME");
                    string nome = Console.ReadLine().ToUpper();
                    Console.WriteLine("INSERISCI IL TUO COGNOME");
                    string cognome = Console.ReadLine().ToUpper();
                    Console.WriteLine("INSERISCI IL TUO CODICE FISCALE");
                    string cf = Console.ReadLine().ToUpper();

                    Console.WriteLine(db.getPersonaFromCF(cf).Item2);
                    Console.WriteLine(db.getPersonaFromCF(cf).Item1.toString());
                    if (db.getPersonaFromCF(cf).Item2 == false)
                    {
                        Persona p = new Persona(nome, cognome, cf);
                        int esito = db.registrazione(p);
                        if (esito > 0)
                        {
                            persona = db.getPersonaFromCF(cf).Item1;
                            Console.WriteLine("");
                            Console.WriteLine("REGISTRAZIONE AVVENUTA CON SUCCESSO!!");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ooops... ABBIAMO RISCONTRATO UN PROBLEMA IN FASE DI REGISTRAZIONE. RITENTA");
                            SignUp();
                        }
                    }
                    else
                    {
                        Console.WriteLine("NEL DB  SONO PRESENTI GIÀ PROFILI CON QUESTO CF. ESEGUI IL LOGIN");
                        benvenuto();
                    }
                }
            }
            catch (FormatException fe)
            {
                benvenuto();
            }
        }

        private static void primaPagina()
        {
            Console.WriteLine("");
            Console.WriteLine("BENVENUTO. COSA VUOI FARE?");
            Console.WriteLine("");
            Console.WriteLine("DIGITA:");
            Console.WriteLine("1) RICHIDI PRESTITO");
            Console.WriteLine("2) VISUALIZZA I TUOI PRESTITI");
            Console.WriteLine("3) ESCI");
            try
            {
                int scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("STAI INSERENDO UNA RICHIESTA DI PRESTITO");
                            Console.WriteLine("");
                            Console.WriteLine("DIGITA 1 PER CONTINUARE O QUALUNQUE ALTRO TASTO PER TORNARE INDIETRO");
                            try
                            {
                                int scelta1 = int.Parse(Console.ReadLine());
                                switch (scelta1)
                                {
                                    case 1:
                                        {
                                            inserisciPrestito();
                                            primaPagina();
                                        };
                                        break;
                                    default:
                                        primaPagina();
                                        break;
                                }
                            }
                            catch (FormatException fe)
                            {
                                primaPagina();
                            }
                        };
                        break;
                    case 2:
                        {
                            Console.WriteLine("");
                            List<Prestito> attivi = ordinaPrestiti(db.getPrestitiFromCF(persona)).Item2;
                            List<Prestito> richiesti = ordinaPrestiti(db.getPrestitiFromCF(persona)).Item1;

                            Console.WriteLine("");
                            Console.WriteLine("PRESTITI ATTIVI: ");
                            if (attivi.Count > 0)
                            {
                                foreach (Prestito prestito in attivi)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Data attivazione: " + prestito.getDataAttivazione() + " Importo: " + prestito.getImporto() + " mensilità: " + prestito.getNRate());
                                }
                            }
                            else Console.WriteLine("NON CI SONO PRESTITI ATTIVI");


                            Console.WriteLine("");
                            Console.WriteLine("PRESTITI RICHIESTI IN ATTESA DI ATTIVAZIONE: ");
                            if (richiesti.Count > 0)
                            {
                                foreach (Prestito prestito in richiesti)
                                {
                                    Console.WriteLine("Data richiesta: " + prestito.getDataRichiesta() + " Importo: " + prestito.getImporto() + " mensilità: " + prestito.getNRate());
                                }
                            }
                            else Console.WriteLine("NON CI SONO PRESTITI IN ATTESA DI ATTIVAZIONE");

                            primaPagina();
                        };
                        break;
                    case 3:
                        uscita();
                        break;
                    default:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                            primaPagina();
                        };
                        break;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                primaPagina();
            }
        }

        private static void inserisciPrestito()
        {
            bool importoCorretto = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("INSERISCI L'IMPORTO RICHIESTO (min 3.000, max 20.000");

                try
                {
                    double importo = double.Parse(Console.ReadLine());
                    if (importo >= 3000 && importo <= 20000)
                    {
                        importoCorretto = true;
                        bool rateCorrette = false;

                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("INSERISCI IL NUMERO DI RATE IN CUI VUOI ESTINGUERE IL PRESTITO (min 3, max 5");

                            try
                            {
                                int nRate = int.Parse(Console.ReadLine());
                                if (nRate >= 3 && nRate <= 5)
                                {
                                    rateCorrette = true;
                                    Console.WriteLine("");
                                    Console.WriteLine("RIEPILOGO DELLA RICHIESTA DI PRESTITO:");
                                    Console.WriteLine("");
                                    Console.WriteLine("PRESTITO RICHIESTO DA: " + persona.toString());
                                    Console.WriteLine("");
                                    Console.WriteLine("IN DATA: " + DateTime.Today + " PER UN AMMONTARE DI: " + importo + "DA ESTINGUERE IN: " + nRate + " ANNI");
                                    Console.WriteLine("");
                                    Console.WriteLine("VUOI CONTINUARE? (y per continuare, qualunque altro tasto per annullare)");
                                    string continua = Console.ReadLine().ToUpper();
                                    if (continua.Equals("Y"))
                                    {
                                        Prestito prestito = new Prestito(0, nRate, importo, false, DateTime.Today.ToShortDateString(), DateTime.Today.ToShortDateString(), persona);
                                        db.inserisciPrestito(prestito);
                                        Console.WriteLine("");
                                        Console.WriteLine("RICHIESTA DI PRESTITO ESEGUITA");
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("RICHIESTA DI PRESTITO ANNULLATA");
                                    }
                                }
                            }

                            catch (FormatException fe)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                            }

                        } while (rateCorrette == false);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("HAI INSERITO UN VALORE NON ACCETTABILE");
                    }
                }

                catch (FormatException fe)
                {
                    Console.WriteLine("");
                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                }

            } while (importoCorretto == true);
        }

        private static (List<Prestito>, List<Prestito>) ordinaPrestiti(List<Prestito> prestiti)
        {
            List<Prestito> richiesti = new List<Prestito>();
            List<Prestito> attivi = new List<Prestito>();
            foreach (Prestito prestito in prestiti)
            {
                Console.WriteLine("");
                Console.WriteLine("ESITO: " + prestito.getEsito());

                if (prestito.getEsito() == true)
                {
                    attivi.Add(prestito);
                }
                else richiesti.Add(prestito);
            }
            return (richiesti, attivi);
        }

        private static void primaPaginaAdmin()
        {
            Console.WriteLine("");
            Console.WriteLine("BENVENUTO ADMIN. COSA VUOI FARE?");
            Console.WriteLine("");
            Console.WriteLine("DIGITA:");
            Console.WriteLine("1) VISUALIZZA TUTTI I PRESTITI");
            Console.WriteLine("2) VALUTA RICHIESTE DI PRESTITO");
            Console.WriteLine("3) ESCI");
            try
            {
                int scelta = int.Parse(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        {
                            List<Prestito> attivi = ordinaPrestiti(db.getPrestiti()).Item2;
                            List<Prestito> richiesti = ordinaPrestiti(db.getPrestiti()).Item1;

                            Console.WriteLine("");
                            Console.WriteLine("PRESTITI ATTIVI: ");
                            if (attivi.Count > 0)
                            {
                                foreach (Prestito prestito in attivi)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Data attivazione: " + prestito.getDataAttivazione() + " Importo: " + prestito.getImporto() + " mensilità: " + prestito.getNRate() + " utente: " + prestito.getPersona().toString());
                                }
                            }
                            else Console.WriteLine("NON CI SONO PRESTITI ATTIVI");


                            Console.WriteLine("");
                            Console.WriteLine("PRESTITI RICHIESTI IN ATTESA DI ATTIVAZIONE: ");
                            if (richiesti.Count > 0)
                            {
                                foreach (Prestito prestito in richiesti)
                                {
                                    Console.WriteLine("Data richiesta: " + prestito.getDataRichiesta() + " Importo: " + prestito.getImporto() + " mensilità: " + prestito.getNRate());
                                }
                            }
                            else Console.WriteLine("NON CI SONO PRESTITI IN ATTESA DI ATTIVAZIONE");

                            primaPaginaAdmin();
                        };
                        break;
                    case 2:
                        {
                            List<Prestito> richiesti = ordinaPrestiti(db.getPrestiti()).Item1;

                            Console.WriteLine("");
                            Console.WriteLine("PRESTITI RICHIESTI IN ATTESA DI ATTIVAZIONE: ");
                            if (richiesti.Count > 0)
                            {
                                foreach (Prestito prestito in richiesti)
                                {
                                    Console.WriteLine("ID Prestito: " + prestito.getIdPrestito() + " Data richiesta: " + prestito.getDataRichiesta() + " Importo: " + prestito.getImporto() + " mensilità: " + prestito.getNRate());
                                }

                                Console.WriteLine("");
                                Console.WriteLine("DIGITA L'ID DEL PRESTITO: ");

                                try
                                {
                                    int id = int.Parse(Console.ReadLine());
                                    if (db.getPrestitiInattiviFromID(id).Item2 == true)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("COSA VUOI FARE?");
                                        Console.WriteLine("1) ATTIVA PRESTITO");
                                        Console.WriteLine("2) ELIMINA RICHIESTA DI PRESTITO");
                                        try
                                        {
                                            int attivare = int.Parse(Console.ReadLine());
                                            switch (attivare)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("SEI SICURO DI VOLER ACCETTARE QUESTO PRESTITO? (y per continuare, qualunque altro tasto per annullare)");
                                                        string continua = Console.ReadLine().ToUpper();
                                                        if (continua.Equals("Y"))
                                                        {
                                                            Prestito p = db.getPrestitoFromID(id);
                                                            db.consentiPrestito(p);
                                                            Console.WriteLine("");
                                                            Console.WriteLine("PRESTITO ATTIVATO!");
                                                            primaPaginaAdmin();
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("");
                                                            Console.WriteLine("RICHIESTA DI AGGIORNAMENTO ANNULLATA");
                                                            primaPaginaAdmin();
                                                        }
                                                    };
                                                    break;
                                                case 2:
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("SEI SICURO DI VOLER CANCELLARE QUESTO PRESTITO? (y per continuare, qualunque altro tasto per annullare)");
                                                        string continua = Console.ReadLine().ToUpper();
                                                        if (continua.Equals("Y"))
                                                        {
                                                            Prestito p = db.getPrestitoFromID(id);
                                                            db.eliminaPrestito(p);
                                                            Console.WriteLine("");
                                                            Console.WriteLine("PRESTITO CANCELLATO!");
                                                            primaPaginaAdmin();
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("");
                                                            Console.WriteLine("RICHIESTA DI AGGIORNAMENTO ANNULLATA");
                                                            primaPaginaAdmin();
                                                        }
                                                    };
                                                    break;
                                                default: {
                                                        Console.WriteLine("CODICE INSERITO NON VALIDO");
                                                        primaPaginaAdmin();
                                                     };
                                                    break;

                                            }
                                        }
                                        catch (FormatException fe)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                                            primaPaginaAdmin();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("L'ID DIGITATO NON È VALIDO");
                                        primaPaginaAdmin();
                                    }
                                }
                                catch (FormatException fe)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                                    primaPaginaAdmin();
                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("NON CI SONO PRESTITI IN ATTESA DI ATTIVAZIONE");
                            }
                            primaPaginaAdmin();
                        };
                        break;
                    case 3:
                        uscita();
                        break;
                    default:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                            primaPagina();
                        };
                        break;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("");
                Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                primaPagina();
            }
        }

        private static void uscita()
        {
            Console.WriteLine("");
            Console.WriteLine("ARRIVADERCI!");
            db.closeDB();
        }
    }
}
