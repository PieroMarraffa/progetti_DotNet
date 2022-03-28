using System;
namespace magazzinoDress
{
    public class Prodotto
    {
        //ATTRIBUTI
        private string nomeProdotto;
        private int disponibilita;


        //CONST, GETTTER & SETTER
        public Prodotto()
        {
        }

        public Prodotto(string NomeProdotto, int Disponibilita)
        {
            this.nomeProdotto = NomeProdotto;
            this.disponibilita = Disponibilita;
        }

        public string getNomeProdotto()
        {
            return this.nomeProdotto;
        }

        public double getDisponibilita()
        {
            return this.disponibilita;
        }

        public void setNomeProdotto(string NomeProdotto)
        {
            this.nomeProdotto = NomeProdotto;
        }

        public void setDisponibilita(int Disponibilita)
        {
            this.disponibilita = Disponibilita;
        }
    }
}
