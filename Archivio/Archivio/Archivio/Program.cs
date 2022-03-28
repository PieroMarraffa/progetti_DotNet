using System;
using MySql.Data.MySqlClient;
//using System.Drawing.Common;

namespace Archivio
{
    class Program
    {
        static void Main(string[] args)
        {

            string connessione = "Server=localhost;Database=Archivio;uid=root;password=";

            int scelta;
            Console.WriteLine("1) inserisci dati studenti");
            Console.WriteLine("2) leggi dati studenti");
            Console.WriteLine("3) cerca uno studente per cognome");
            scelta = int.Parse(Console.ReadLine());

            try
            {
                MySqlConnection cn = new MySqlConnection(connessione);
                cn.Open();
                Console.WriteLine("CONNESSIONE RIUSCITA");
                if(scelta == 1)
                {
                    Console.WriteLine("inserisci il nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("inserisci il cognome");
                    string cognome = Console.ReadLine();
                    Console.WriteLine("inserisci età");
                    int eta = int.Parse(Console.ReadLine());
                    string sql = "INSERT INTO `Rubrica` (`Nome`, `Cognome`, `Eta`) VALUES('"+ nome + "', '" + cognome + "', '" + eta + "')";
                    MySqlCommand command = new MySqlCommand(sql, cn);
                    command.ExecuteNonQuery();
                }
                else if(scelta == 2)
                {
                    string sql = "SELECT * FROM Rubrica";
                    MySqlCommand command = new MySqlCommand(sql, cn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString("Nome") + ", " + reader.GetString("Cognome") + ", " + reader.GetInt32("Eta"));
                    }
                } else if(scelta == 3)
                {
                    Console.WriteLine("inserisci il cognome");
                    string cognome = Console.ReadLine();
                    string sql = "SELECT * FROM Rubrica where Cognome = '" + cognome + "'";
                    MySqlCommand command = new MySqlCommand(sql, cn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString("Nome") + ", " + reader.GetString("Cognome") + ", " + reader.GetInt32("Eta"));
                    }
                }
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
