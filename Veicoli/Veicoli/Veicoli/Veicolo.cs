using System;
namespace Veicoli
{
    public class Veicolo
    {
        //ATTRIBUTI
        protected string targa, marca, modello;
        protected int posti;


        //CONST, GETTER & SETTER
        public Veicolo()
        {
        }

        public Veicolo(string Targa, string Marca, string Modello, int Posti)
        {
            this.targa = Targa;
            this.marca = Marca;
            this.modello = Modello;
            this.posti = Posti;
        }

        public string getTarga()
        {
            return this.targa;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public string getModello()
        {
            return this.modello;
        }

        public int getPosti()
        {
            return this.posti;
        }

        public void setTarga(string Targa)
        {
            this.targa = Targa;
        }

        public void setMarca(string Marca)
        {
            this.marca = Marca;
        }

        public void setModello(string Modello)
        {
            this.modello = Modello;
        }

        public void setPosti(int Posti)
        {
            this.posti = Posti;
        }
    }
}
