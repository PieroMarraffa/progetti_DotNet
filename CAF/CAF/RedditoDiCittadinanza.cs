using System;
namespace CAF
{
    public class RedditoDiCittadinanza
    {
        //DICIARAZIONE ATTRIBUTI
        private Person utente;


        //DICHIARAZIONE COSTANTI
        public const int LIMITE_SUPERIORE_ISEE = 9360;
        public const int LIMITE_SUPERIORE_PATRIMONIO_IMMOBILIARE = 30000;
        public const int LIMITE_INFERIORE_ETA = 26;
        public const int LIMITE_SUPERIORE_ETA = 67;


        //CONSTRUCTOR, GETTER E SETTER
        public RedditoDiCittadinanza()
        {
        }

        public RedditoDiCittadinanza(Person Utente)
        {
            this.utente = Utente;
        }

        public Person getUtente()
        {
            return this.utente;
        }

        public void setUtente(Person Utente)
        {
            this.utente = Utente;
        }


        //DICHIARAZIONE METODI DI GESTIONE

        public bool verificaEta()
        {
            if (this.utente.getEta() >= LIMITE_INFERIORE_ETA && this.utente.getEta() <= LIMITE_SUPERIORE_ETA)
            {
                return true;
            }
            else return false;
        }

        public bool verificaISEE()
        {
            if (this.utente.getIsee() < LIMITE_SUPERIORE_ISEE)
            {
                return true;
            }
            else return false;
        }

        public bool verificaPatrimonioImmobiliare()
        {
            if (this.utente.getPatrimonioImmobiliare() < LIMITE_SUPERIORE_PATRIMONIO_IMMOBILIARE)
            {
                return true;
            }
            else return false;
        }

        public bool verificaDiritto()
        {
            if (verificaEta() == true && verificaISEE() == true && verificaPatrimonioImmobiliare() == true)
            {
                return true;
            }
            else return false;
        }
    }
}
