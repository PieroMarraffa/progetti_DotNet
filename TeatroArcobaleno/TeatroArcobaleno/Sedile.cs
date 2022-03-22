using System;
namespace TeatroArcobaleno
{
    public class Sedile
    {
        //ATTRIBUTI
        private Persona spettatore;
        private int fila, colonna;


        //CONST, GETTER & SETTER
        public Sedile()
        {
        }

        public Sedile(Persona persona, int Fila, int Colonna)
        {
            this.spettatore = persona;
            this.fila = Fila;
            this.colonna = Colonna;
        }

        public Persona getPersona()
        {
            return this.spettatore;
        }

        public int getFila()
        {
            return this.fila;
        }

        public int getColonna()
        {
            return this.colonna;
        }

        public void setSpettatore(Persona persona)
        {
            this.spettatore = persona;
        }

        public void setFila(int Fila)
        {
            this.fila = Fila;
        }

        public void setColonna(int Colonna)
        {
            this.colonna = Colonna;
        }

        //METODI DI GESTIONE DELLE ISTANZE
        public void setSedileVuoto()
        {
            this.getPersona().setNome("");
            this.getPersona().setCognome("");
            this.getPersona().setEta(-1);
        }

        public string toString()
        {
            return ("posto di " + spettatore.getNome() + " numero " + (colonna + ((fila - 1) * 10)));
        }
    }
}
