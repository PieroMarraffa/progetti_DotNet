using System;
namespace PrimoProgetto
{
    public class AltroFile
    {
        public AltroFile()
        { 
        }

        public static void OperazioniNumeriche()
        {
            /*in questo metodo vado a prendere due numeri dalla read line per andarli ad utilizzare in delle operazione
             Autore: Piero
            Data 15-3-2022*/

            Console.WriteLine("inserisci il primo numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num2 + num1;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }

        public static void gestioneCF()
        {
            /*IN QUESTO METODO ANDRÒ A GESTIRE GLI ELEMENTI DEL CODICE FISCALE (mrrpri99t24a345x)
            AUTORE: PIERO
        DATA: 15-3-2022*/
            Console.WriteLine("inserisci il tuo codice fiscale: ");
            string cf = Console.ReadLine();

            //vado ora a contare quanti caratteri sono stati inseriti:
            Console.WriteLine("hai inserito " + cf.Length + " caratteri");

            //vado a calcolare l'età:
            string birthYearStr = cf.Substring(6, 2);
            int birthYear = int.Parse(birthYearStr);
            int age = 2022 - (1900 + birthYear);
            Console.WriteLine("la tua età è: " + age);
        }
    }
}
