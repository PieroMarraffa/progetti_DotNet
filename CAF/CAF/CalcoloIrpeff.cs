using System;
namespace CAF
{
    public class CalcoloIrpeff
    {
        //DICIARAZIONE ATTRIBUTI
        private Person utente;
        private int scaglione;


        //DICHIARAZIONE COSTANTI
        private const int LIMITE_MASSIMO_1 = 15000;
        private const int LIMITE_MASSIMO_2 = 28000;
        private const int LIMITE_MASSIMO_3 = 55000;
        private const int LIMITE_MASSIMO_4 = 75000;
        private const double IRPEF_GRUPPO_1 = 0.23;
        private const double IRPEF_GRUPPO_2 = 0.27;
        private const double IRPEF_GRUPPO_3 = 0.38;
        private const double IRPEF_GRUPPO_4 = 0.41;
        private const double IRPEF_GRUPPO_5 = 0.43;


        //CONSTRUCTOR, GETTER E SETTER
        public CalcoloIrpeff()
        {
        }

        public CalcoloIrpeff(Person Utente)
        {
            this.utente = Utente;
        }

        public CalcoloIrpeff(Person Utente, int Scaglione)
        {
            this.utente = Utente;
            this.scaglione = Scaglione;
        }

        public Person getUtente()
        {
            return this.utente;
        }

        public int getScaglione()
        {
            return this.scaglione;
        }

        public void setUtente(Person Utente)
        {
            this.utente = Utente;
        }

        public void setScaglione(int Scaglione)
        {
            this.scaglione = Scaglione;
        }


        //DICHIARAZIONE METODI DI GESTIONE

        public int calcoloScaglione()
        {
            if (utente.getReddito() <= LIMITE_MASSIMO_1)
            {
                return 1;
            } else if(utente.getReddito() <= LIMITE_MASSIMO_2)
            {
                return 2;
            }
            else if (utente.getReddito() <= LIMITE_MASSIMO_3)
            {
                return 3;
            }
            else if (utente.getReddito() <= LIMITE_MASSIMO_4)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        public double calcoloTassazione()
        {

            this.scaglione = calcoloScaglione();

            switch (scaglione)
            {
                case 1:
                    return (utente.getReddito() * IRPEF_GRUPPO_1);
                    break;

                case 2:
                    return (utente.getReddito() * IRPEF_GRUPPO_1);
                    break;

                case 3:
                    return (utente.getReddito() * IRPEF_GRUPPO_1);
                    break;

                case 4:
                    return (utente.getReddito() * IRPEF_GRUPPO_1);
                    break;

                case 5:
                    return (utente.getReddito() * IRPEF_GRUPPO_1);
                    break;

                default: return 0;
            }
        }
    }
}
