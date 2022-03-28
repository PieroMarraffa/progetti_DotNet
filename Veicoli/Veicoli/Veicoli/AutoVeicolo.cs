using System;
namespace Veicoli
{
    public class AutoVeicolo : Veicolo
    {
        //ATTRIBUTI
        private int numeroPorte;


        //CONST, GETTER & SETTER
        public AutoVeicolo()
        {
        }

        public AutoVeicolo(string Targa, string Marca, string Modello, int Posti, int NumeroPorte) : base(Targa, Marca, Modello, Posti)
        {
            this.numeroPorte = NumeroPorte;
        }

        public int getCapacita()
        {
            return this.numeroPorte;
        }

        public void setCapacita(int NumeroPorte)
        {
            this.numeroPorte = NumeroPorte;
        }

        //METODI DI GESTIONE DELLA CLASSE
        public string toString()
        {
            return ("Targa: " + this.targa + " Marca: " + this.marca + " Modello: " + this.modello + " Posti: " + this.posti + " Tipo: AutoVaicolo Capacità: " + this.numeroPorte);
        }

        public bool equalsTo(AutoVeicolo veicolo)
        {
            if (veicolo.getTarga() == this.targa)
            {
                return true;
            }
            else return false;
        }
    }
}
