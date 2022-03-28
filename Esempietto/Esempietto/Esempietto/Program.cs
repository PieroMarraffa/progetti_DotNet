using System;
using MySql.Data.MySqlClient;

namespace Esempietto
{
    class Program
    {
        static void Main(string[] args)
        {
            string connessione = "Server=localhost;Database=Archivio;uid=root;password=Pippo1999";

            int scelta;
            Console.WriteLine("1) inserisci dati studenti");
            Console.WriteLine("2) leggi dati studenti");
            //scelta = int.Parse(Console.ReadLine());

            try
            {
                MySqlConnection cn = new MySqlConnection(connessione);
                cn.Open();
                Console.WriteLine("CONNESSIONE RIUSCITA");
                cn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("CONNESSIONE NON RIUSCITA");
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
