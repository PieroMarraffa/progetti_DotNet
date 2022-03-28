using System;
namespace Veicoli
{
    public class AutoCarro : Veicolo
    {
        //ATTRIBUTI
        private int capacitaMassima;

        //CONST, GETTER & SETTER
        public AutoCarro()
        {
        }

        public AutoCarro(string Targa, string Marca, string Modello, int Posti, int CapacitaMassima) : base(Targa, Marca, Modello, Posti)
        {
            this.capacitaMassima = CapacitaMassima;
        }

        public int getCapacita()
        {
            return this.capacitaMassima;
        }

        public void setCapacita(int CapacitaMassima)
        {
            this.capacitaMassima = CapacitaMassima;
        }

        //METODI DI GESTIONE DELLA CLASSE
        public string toString()
        {
            return ("Targa: " + this.targa + " Marca: " + this.marca + " Modello: " + this.modello + " Posti: " + this.posti + "  Tipo: AutoVaicolo Capacità: " + this.capacitaMassima);
        }

        public bool equalsTo(AutoCarro carro)
        {
            if (carro.getTarga() == this.targa)
            {
                return true;
            }
            else return false;
        }
    }
}
