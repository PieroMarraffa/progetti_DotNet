using System;
using System.Collections.Generic;

namespace ZooAstratto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<AZoo> animali = new List<AZoo>();
            bool fine = false;
            while (!fine)
            {
                Console.WriteLine("inserisci un animale:");
                Console.WriteLine("scegli: ");
                Console.WriteLine("1) per inserire un leone");
                Console.WriteLine("2) per inserire una gazella");
                Console.WriteLine("3) per terminare la registrazione");
                try
                {
                    int scelta = int.Parse(Console.ReadLine());
                    switch (scelta)
                    {
                        case 1:
                            {
                                Console.WriteLine("inserisci il nome:");
                                string nome = Console.ReadLine();
                                Leone leo = new Leone(nome);
                                Console.WriteLine("scegli: ");
                                Console.WriteLine("1) se dorme");
                                Console.WriteLine("2) se mangia");
                                Console.WriteLine("3) se ruggisce");
                                try
                                {
                                    int sceltaAzione = int.Parse(Console.ReadLine());
                                    switch (sceltaAzione)
                                    {
                                        case 1:
                                            leo.Dorme();
                                            animali.Add(leo);
                                            ;
                                            break;
                                        case 2:
                                            leo.Mangia();
                                            animali.Add(leo);
                                            break;
                                        case 3:
                                            leo.Azione();
                                            animali.Add(leo);
                                            break;
                                        default:
                                            Console.WriteLine("");
                                            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                                }
                            };
                            break;
                        case 2:
                            {
                                Console.WriteLine("inserisci il nome:");
                                string nome = Console.ReadLine();
                                Gazella mariella = new Gazella(nome);
                                Console.WriteLine("scegli: ");
                                Console.WriteLine("1) se dorme");
                                Console.WriteLine("2) se mangia");
                                Console.WriteLine("3) se scappa");
                                try
                                {
                                    int sceltaAzione = int.Parse(Console.ReadLine());
                                    switch (sceltaAzione)
                                    {
                                        case 1:
                                            mariella.Dorme();
                                            animali.Add(mariella);
                                            ;
                                            break;
                                        case 2:
                                            mariella.Mangia();
                                            animali.Add(mariella);
                                            break;
                                        case 3:
                                            mariella.Azione();
                                            animali.Add(mariella);
                                            break;
                                        default:
                                            Console.WriteLine("");
                                            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                                            break;
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                                }
                            };
                            break;
                        case 3:
                            fine = true;
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("");
                    Console.WriteLine("HAI INSERITO UN CODICE NON RICONOSCIUTO");
                }
            }
            foreach (AZoo animale in animali)
            {
                Console.WriteLine(animale.getAzione());
                animale.Dorme();
            }
        }
    }
}
