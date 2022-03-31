using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Cellulari
{
    public class DB
    {
        private MySqlConnection connection;
        private bool open;

        public DB(string nomeDB)
        {
            string connessione = "Server=localhost;Database=" + nomeDB + ";uid=root;password=";
            this.connection = new MySqlConnection(connessione);
        }

        public void openDB()
        {
            if (open == false)
            {
                connection.Open();
                open = true;
            }
        }

        public void closeDB()
        {
            if (open == true)
            {
                connection.Close();
                open = false;
            }
        }

        public List<Cellulare> getCellulari()
        {
            List<Cellulare> cellulari = new List<Cellulare>();
            string query = "SELECT * FROM cellulare ORDER BY `idCellulare` ASC";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cellulare cel = new Cellulare(reader.GetInt32("idCellulare"), reader.GetString("Marca"), reader.GetString("Modello"), reader.GetDouble("Prezzo"));
                cellulari.Add(cel);
            }

            return cellulari;
        }

        public bool insertCell(Cellulare cel)
        {
            string query = $"INSERT INTO `Cellulare`( `Marca`, `Modello`, `Prezzo`) VALUES('{cel.getMarca()}', '{cel.getModello()}', {cel.getPrezzo()}')";
            MySqlCommand command = new MySqlCommand(query, connection);
            int numeroRighe = command.ExecuteNonQuery();
            if (numeroRighe > 0) return true;
            else return false;
        }
    }
}
