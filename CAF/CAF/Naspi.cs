using System;
namespace CAF
{
    public class Naspi
    {
        //DICIARAZIONE ATTRIBUTI
        private Person utente;


        //DICHIARAZIONE COSTANTI
        private const int LIMITE_MASSIMO_NASPI = 1200;
        private const double LIVELLO_1 = 0.70;
        private const double LIVELLO_2 = 0.40;

        //CONSTRUCTOR, GETTER E SETTER
        public Naspi()
        {
        }

        public Naspi(Person Utente)
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


        //METODI DI GESTIONE

        public int calcoloLivello()
        {
            if ((utente.getAnniLavorativiUltimaOccupazione() * 12) >= 24)
            {
                return 1;
            }
            else if ((utente.getAnniLavorativiUltimaOccupazione() * 12) < 24 && (utente.getAnniLavorativiUltimaOccupazione() * 12) >= 12)
            {
                return 2;
            }
            else return 0;
        }

        public bool verificaDiritto()
        {
            if (calcoloLivello() != 0)
            {
                return true;
            }
            else return false;
        }

        public double calcoloAmmontare()
        {
            int livello = calcoloLivello();

            switch (livello)
            {
                case 1: return (utente.getReddito() * LIVELLO_1);
                    break;

                case 2: return (utente.getReddito() * LIVELLO_2);
                    break;

                case 3: return 0;

                default: return 0;
            }
        }
    }
}
