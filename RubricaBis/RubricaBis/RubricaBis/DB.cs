using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace RubricaBis
{
    public class DB
    {
        private static MySqlConnection cn;

        public static void getInstance(string nomeDB)
        {
            string connessione = "Server=localhost;Database="+nomeDB+";uid=root;password=";
            DB.cn = new MySqlConnection(connessione);
            DB.cn.Open();
        }

        public static void closeDB()
        {
            DB.cn.Close();
        }

        public static List<Persona> getAllPersone()
        {
            List<Persona> allPersone = new List<Persona>();
            string query = "SELECT * FROM Rubrica";
            MySqlCommand command = new MySqlCommand(query, DB.cn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Persona p = new Persona(reader.GetString("Nome"), reader.GetString("Cognome"), reader.GetInt32("Eta"));
                allPersone.Add(p);
            }
            return allPersone;
        }

        public static List<Persona> getPersoneFromCognome(string selector)
        {
            List<Persona> allPersone = new List<Persona>();
            string query = "SELECT * FROM Rubrica WHERE Cognome = '" + selector + "'";
            MySqlCommand command = new MySqlCommand(query, DB.cn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Persona p = new Persona(reader.GetString("Nome"), reader.GetString("Cognome"), reader.GetInt32("Eta"));
                allPersone.Add(p);
            }
            return allPersone;
        }

        public static int insertPersona(Persona persona)
        {
            string sql = "INSERT INTO `Rubrica` (`Nome`, `Cognome`, `Eta`) VALUES('" + persona.getNome() + "', '" + persona.getCognome() + "', '" + persona.getEta() + "')";
            MySqlCommand command = new MySqlCommand(sql, cn);
            int numeroRigheInserite = command.ExecuteNonQuery();
            return numeroRigheInserite;
        }
    }
}
