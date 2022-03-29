using System;
namespace PrestiFastFinanziaria
{
    public class Persona
    {
        //ATTRIBUTI
        private int idPersona;
        private string nome, cognome, codFisc;


        //CONST, GETTER & SETTER
        public Persona()
        {
        }

        public Persona(string Nome, string Cognome, string CodFisc)
        {
            this.nome = Nome;
            this.cognome = Cognome;
            this.codFisc = CodFisc;
        }

        public Persona(int IdPersona, string Nome, string Cognome, string CodFisc)
        {
            this.idPersona = IdPersona;
            this.nome = Nome;
            this.cognome = Cognome;
            this.codFisc = CodFisc;
        }

        public int getIdPersona()
        {
            return this.idPersona;
        }

        public void setIdPersona(int id)
        {
            this.idPersona = id;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string n)
        {
            this.nome = n;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public void setCognome(string c)
        {
            this.cognome = c;
        }

        public string getCodFisc()
        {
            return this.codFisc;
        }

        public void setCodFisc(string cod)
        {
            this.codFisc = cod;
        }


        //METODI DI GESTIONE DELLA CLASSE

        public string toString()
        {
            return ("Nome: " + this.nome + " Cognome: " + this.cognome + " Codice Fiscale: " + this.codFisc);
        }

        public bool equalTo(Persona persona)
        {
            if (this.nome.Equals(persona.getNome()) && this.cognome.Equals(persona.getCognome()) && this.codFisc.Equals(persona.getCodFisc()))
            {
                return true;
            }
            else return false;
        }
    }
}
