using System;

namespace Rubrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo Cognome: ");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci la tua Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo Cellulare: ");
            long cellulare = long.Parse(Console.ReadLine());

            gestioneRubrica rubrica = new gestioneRubrica(nome, cognome, email, cellulare);
            Console.WriteLine(rubrica.toString());

        }
    }
}
