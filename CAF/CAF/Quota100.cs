using System;
namespace CAF
{
    public class Quota100
    {
        //DICIARAZIONE ATTRIBUTI
        private Person utente;


        //CONSTRUCTOR, GETTER E SETTER
        public Quota100()
        {
        }

        public Quota100(Person Utente)
        {
            this.utente = Utente;
        }

        public Person getUtente()
        {
            return utente;
        }

        public void setUtente(Person Utente)
        {
            this.utente = Utente;
        }


        //DICHIARAZIONE METODI DI GESTIONE

        public bool verificaDiritto()
        {
            if (utente.getEta() + utente.getAnniLavorativi() >= 100)
            {
                return true;
            }
            else
                return false;
        }

        public int calcoloAnniMancantiAttivi()
        {
            if (verificaDiritto() == false)
            {
                int mancanzaTot = 100 - (utente.getEta() + utente.getAnniLavorativi());
                if((mancanzaTot % 2) != 0)
                {
                    return (mancanzaTot / 2) + 1;
                }
                else
                {
                    return (mancanzaTot / 2);
                }
            }
            else return 0;
        }

        public int calcoloAnniMancantiPassivi()
        {
            if (verificaDiritto() == false)
            {
                return (100 - (utente.getEta() + utente.getAnniLavorativi()));
            }
            else return 0;
        }
    }
}
