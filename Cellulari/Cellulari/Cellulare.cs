using System;
namespace Cellulari
{
    public class Cellulare
    {
        private int idCellulare;
        private string marca, modello;
        private double prezzo;

        public Cellulare()
        {
        }

        public Cellulare(string marca, string modello, double prezzo)
        {
            this.marca = marca;
            this.modello = modello;
            this.prezzo = prezzo;
        }

        public Cellulare(int idCellulare, string marca, string modello, double prezzo)
        {
            this.idCellulare = idCellulare;
            this.marca = marca;
            this.modello = modello;
            this.prezzo = prezzo;
        }

        public int getId()
        {
            return this.idCellulare;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public string getModello()
        {
            return this.modello;
        }

        public double getPrezzo()
        {
            return this.prezzo;
        }

        public string  toString()
        {
            return $"{this.idCellulare}) Marca: {this.marca} Modello: {this.modello} Prezzo: {this.prezzo}";
        }
    }
}
