using System;
namespace TeatroArcobaleno
{
    public class Persona
    {

        //ATTRIBUTI
        private string nome, cognome;
        private int eta;


        //CONST, GETTER & SETTER
        public Persona()
        {
        }

        public Persona(string Nome, string Cognome, int Eta)
        {
            this.nome = Nome;
            this.cognome = Cognome;
            this.eta = Eta;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public int getEta()
        {
            return this.eta;
        }

        public void setNome(string Nome)
        {
            this.nome = Nome;
        }

        public void setCognome(string Cognome)
        {
            this.cognome = Cognome;
        }

        public void setEta(int Eta)
        {
            this.eta = Eta;
        }


        //METODI DI GESTIONE DELLA CLASSE
        public string toString()
        {
            return (nome + cognome + eta);
        }
    }
}
