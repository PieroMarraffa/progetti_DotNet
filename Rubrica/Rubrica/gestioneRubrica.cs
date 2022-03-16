using System;
namespace Rubrica
{
    public class gestioneRubrica
    {

        //ATTRIBUTI
        private string nome, cognome, email;
        private long cellulare;

        //COSTRUTTORE, GETTER AND SETTER

        public gestioneRubrica()
        {

        }

        public gestioneRubrica(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public gestioneRubrica(string nome, string cognome, string email, long cellulare)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.cellulare = cellulare;
        }

        public void setNome(string dato)
        {
            this.nome = dato;
        }

        public void setCognome(string dato)
        {
            this.cognome = dato;
        }

        public void setEmail(string dato)
        {
            this.email = dato;
        }

        public void setCellulare(long dato)
        {
            this.cellulare = dato;
        }

        public string getNome()
        {
            return nome;
        }

        public string getCognome()
        {
            return cognome;
        }

        public string getEmail()
        {
            return email;
        }

        public long getCellulare()
        {
            return cellulare;
        }

        //METODI UTILI

        public string toString()
        {
            return "I tuoi dati sono:   Nome: " + this.nome + "    Cognome: " + this.cognome + "    Email: " + this.email + "    Cellulare: " + this.cellulare;
        }
    }
}
