using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace PrestiFastFinanziaria
{
    public class DB
    {

        private MySqlConnection connection;
        private bool open = false;

        public DB(string nomeDB)
        {
            string connessione = "Server=localhost;Database=" + nomeDB + ";uid=root;password=";
            this.connection = new MySqlConnection(connessione);
        }

        public void openDB()
        {
            if(open == false)
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

        public (Persona, bool) getPersonaFromCF(string cf)
        {
            bool toReturn = false;
            string query = "SELECT * FROM persona WHERE `CodiceFiscale` = '" + cf + "'";
            Persona p = new Persona();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                toReturn = true;
                p = new Persona(reader.GetInt32("IdPersona"), reader.GetString("Nome"), reader.GetString("Cognome"), reader.GetString("CodiceFiscale"));
            }
            reader.Close();
            return (p, toReturn);
        }

        public List<Persona> getPersone()
        {
            List<Persona> persone = new List<Persona>();

            string query = "SELECT * FROM persona";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Persona p = new Persona(reader.GetInt32("IdPersona"), reader.GetString("Nome"), reader.GetString("Cognome"), reader.GetString("CodiceFiscale"));
                persone.Add(p);
            }
            reader.Close();
            return persone;
        }

        private Dictionary<int, Persona> getMapPersone()
        {
            Dictionary<int, Persona> map = new Dictionary<int, Persona>();
            List<Persona> persone = getPersone();
            foreach(Persona p in persone)
            {
                map.Add(p.getIdPersona(), p);
            }
            return map;
        }

        public List<Prestito> getPrestiti()
        {
            List<Prestito> prestiti = new List<Prestito>();
            Dictionary<int, Persona> map = getMapPersone();

            string query = "SELECT * FROM prestitiAttivi";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                int idPersona = reader1.GetInt32("IdPersona");
                Persona persona = map.GetValueOrDefault(idPersona);

                Prestito prestito = new Prestito(reader1.GetInt32("IdPrestito"), reader1.GetInt32("nRate"), reader1.GetDouble("Importo"), reader1.GetBoolean("esito"), reader1.GetString("dataAttivazione"), reader1.GetString("dataRichiesta"), persona);
                prestiti.Add(prestito);
            }
            reader1.Close();
            return prestiti;
        }

        public Prestito getPrestitoFromID(int id)
        {
            Prestito prestito = new Prestito();
            Dictionary<int, Persona> map = getMapPersone();

            string query = "SELECT * FROM prestitiAttivi WHERE `idPrestito` = '" + id + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                int idPersona = reader1.GetInt32("IdPersona");
                Persona persona = map.GetValueOrDefault(idPersona);

                prestito = new Prestito(reader1.GetInt32("IdPrestito"), reader1.GetInt32("nRate"), reader1.GetDouble("Importo"), reader1.GetBoolean("esito"), reader1.GetString("dataAttivazione"), reader1.GetString("dataRichiesta"), persona);
            }
            reader1.Close();
            return prestito;
        }

        public List<Prestito> getPrestitiFromCF(Persona persona)
        {
            List<Prestito> toReturn = new List<Prestito>();
            List<Prestito> tuttiPrestiti = getPrestiti();

            foreach(Prestito prestito in tuttiPrestiti)
            {
                if (prestito.getPersona().equalTo(persona) == true)
                {
                    toReturn.Add(prestito);
                }
            }
            return toReturn;
        }

        public (Prestito, bool) getPrestitiInattiviFromID(int id)
        {
            Prestito toReturn = new Prestito();
            bool esistente = false;
            List<Prestito> tuttiPrestiti = getPrestiti();

            foreach (Prestito prestito in tuttiPrestiti)
            {
                if (prestito.getIdPrestito() == id && prestito.getEsito() == false)
                {
                    toReturn = prestito;
                    esistente = true;
                }
            }
            return (toReturn, esistente);
        }

        public int registrazione(Persona p)
        {
            string query = "INSERT INTO `persona` (`idPersona`, `Nome`, `Cognome`, `CodiceFiscale`) VALUES(NULL, '" + p.getNome() + "', '" + p.getCognome() + "', '" + p.getCodFisc() + "')";
            MySqlCommand command = new MySqlCommand(query, connection);
            int numeroRigheInserite = command.ExecuteNonQuery();
            return numeroRigheInserite;
        }

        public int inserisciPrestito(Prestito p)
        {
            string query = "INSERT INTO `prestitiAttivi`(`idPrestito`, `idPersona`, `importo`, `nRate`, `esito`, `dataAttivazione`, `dataRichiesta`) VALUES (NULL,'" + p.getPersona().getIdPersona() + "','" + p.getImporto() + "','" + p.getNRate() + "','" + 0 + "','','" + (DateTime.Today.ToShortDateString()) + "')";
            MySqlCommand command = new MySqlCommand(query, connection);
            int numeroRigheInserite = command.ExecuteNonQuery();
            return numeroRigheInserite;
        }

        public int consentiPrestito(Prestito p)
        {
            string query = "UPDATE `prestitiAttivi` SET `esito`='1' WHERE `idPrestito` = '" + p.getIdPrestito() + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            int numeroRigheInserite = command.ExecuteNonQuery();
            return numeroRigheInserite;
        }

        public int eliminaPrestito(Prestito p)
        {
            string query = "DELETE FROM `prestitiAttivi` WHERE `idPrestito` = '" + p.getIdPrestito() + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            int numeroRigheInserite = command.ExecuteNonQuery();
            return numeroRigheInserite;
        }
    }
}
