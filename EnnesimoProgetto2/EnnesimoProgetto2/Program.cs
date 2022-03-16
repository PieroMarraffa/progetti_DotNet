using System;

namespace EnnesimoProgetto2
{
    class Program
    {
        static void Main(string[] args)
        {

            //vado a testare i metodi della classe calcolatrice

            Calcolatrice calcolatrice = new Calcolatrice();

            Console.WriteLine("INSERISCI IL PRIMO NUMERO: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("INSERISCI IL SECONDO NUMERO: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("LA SOMMA È: " + calcolatrice.somma(num1, num2));
            Console.WriteLine("LA DIFFERENZA È: " + calcolatrice.differenza(num1, num2));
            Console.WriteLine("IL PRODOTTO È: " + calcolatrice.prodotto(num1, num2));
            Console.WriteLine("IL RAPPORTO È: " + calcolatrice.rapporto(num1, num2));
            Console.WriteLine("IL RAPPORTO ARROTONDATO È: " + calcolatrice.rapportoArrotondato(num1, num2));
        }
    }
}
