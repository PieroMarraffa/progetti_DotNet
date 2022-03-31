using System;

namespace EventiECallback
{
     delegate int Calcolatore(int a, int b);
    class MainClass
    {
        public static void Main(string[] args)
        {
            int r = Matematica.aggiungi(1, 2);
            int k = Matematica.moltiplica(2, 3);

            /*
             * dopo aver usato tante volte queste istruzioni posso avere la necessità di passare dalla classe 
             * Matematica a NewMaths
             * */

            r = NewMath.Add(1, 2);

            /*
             *piuttosto che stare a fare sto sbatti avrei potuto usare un delegato
             * */

            Calcolatore Somma = Matematica.aggiungi;
            Calcolatore Prodotto = Matematica.moltiplica;

            r = Somma(1, 2);
            k = Prodotto(2, 3);

            //ORA CAMBIO LA CLASSE MATEMATICA
            Somma = NewMath.Add;
            Prodotto = NewMath.Multiply;

            r = Somma(1, 2);
            k = Prodotto(2, 3);

            /*
             * in questo modo avrei dovuto cambiare solo la dichiarazione dei metodi e non tutti i metodi 
             * per intero
             * */
        }
    }
}
