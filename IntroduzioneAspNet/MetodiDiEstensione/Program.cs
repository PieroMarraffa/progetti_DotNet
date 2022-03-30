using System;
using MetodiDiEstensione;

namespace MetodiDiEstensione
{
    class Program
    {
        static void Main(string[] args)
        {
            //Voglio, grazie all'ereditarietà, un metodo mio alla classe String
            string nome = "Piero";

            //Il mio metodo si chiamerà ToMaiuscolo()
            //potrei ereditare da String

            //BUGIA PERCHÈ STRING È DEFINITA "SEALED" A MENO CHE NON USO I METODI ESTESI
            Console.WriteLine(nome.toMaiuscolo());

            //ora uso il metodo per gli interi
            int eta = 22;
            Console.WriteLine(eta.divisoPerDue());
        }
    }
}
