using System;

namespace PrimoProgetto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*in questo momento vado a prendere due numeri dalla read line per andarli ad utilizzare in delle operazion
             Autore: Piero
            Data 15-3-2022*/

            Console.WriteLine("inserisci il primo numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num2 + num1;
            Console.WriteLine(num1 + " + " + num2 + " = " +sum);
        }
    }
}
