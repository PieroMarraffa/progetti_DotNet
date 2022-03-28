using System;
using System.Collections.Generic;

namespace RubricaBis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                DB.getInstance("Archivio");

                Console.WriteLine("BENVENUTO!!!");
                int scelta = 1;
                while (scelta != 0)
                {
                    Console.WriteLine("INSERISCI:");
                    Console.WriteLine("1) VISUALIZZA TUTTA LA RUBRICA");
                    Console.WriteLine("2) ESEGUI UNA RICERCA PER COGNOME");
                    Console.WriteLine("3) INSERISCI UNA PERSONA IN RUBRICA");
                    Console.WriteLine("0) ESCI");
                    try
                    {
                        scelta = int.Parse(Console.ReadLine());
                        switch (scelta)
                        {
                            case 1:
                                {
                                    List<Persona> persone = DB.getAllPersone();
                                    if(persone.Count < 1)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("NON CI SONO PERSONE IN RUBRICA");
                                    }
                                    else
                                    {
                                        foreach (Persona persona in persone)
                                        {
                                            Console.WriteLine(persona.toString());
                                        }
                                    }
                                };
                                break;
                            case 2:
                                {
                                    Console.WriteLine("INSERISCI IL COGNOME DELLA PERSONA DA CERCARE: ");
                                    string cognome = Console.ReadLine();
                                    List<Persona> persone = DB.getPersoneFromCognome(cognome);
                                    if (persone.Count < 1)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("NON CI SONO PERSONE CON QUESTO COGNOME IN RUBRICA");
                                    }
                                    else
                                    {
                                        foreach (Persona persona in persone)
                                        {
                                            Console.WriteLine(persona.toString());
                                        }
                                    }
                                };
                                break;
                            case 3:
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("INSERISCI IL NOME DELLA PERSONA DA AGGIUNGERE");
                                    string nome = Console.ReadLine();
                                    Console.WriteLine("");
                                    Console.WriteLine("INSERISCI IL COGNOME DELLA PERSONA DA AGGIUNGERE");
                                    string cognome = Console.ReadLine();
                                    Console.WriteLine("");
                                    Console.WriteLine("INSERISCI L'ETÀ DELLA PERSONA DA AGGIUNGERE");
                                    try
                                    {
                                        int eta = int.Parse(Console.ReadLine());
                                        Persona persona = new Persona(nome, cognome, eta);
                                        DB.insertPersona(persona);
                                    } catch(Exception e)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("PER INSERIRE L'ETÀ DEVI INSERIRE UN NUMERO INTERO");
                                    }
                                };
                                break;
                            case 0:;
                                break;
                            default:
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO (numero non valutato)");
                                };
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO (scelta)");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("ARRIVEDERCI!!!");
                DB.closeDB();
            } catch(Exception e)
            {
                Console.WriteLine("oops... QUALCOSA È ANDATO STORTO :( ");
            }
        }
    }
}
