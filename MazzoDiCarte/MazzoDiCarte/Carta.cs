using System;
namespace MazzoDiCarte
{
    public class Carta
    {
        string valore, seme;
        int idCarta;

        public Carta()
        {
        }

        public Carta(int id, string Valore, string Seme)
        {
            this.valore = Valore;
            this.seme = Seme;
            this.idCarta = id;
        }

        public int getId()
        {
            return this.idCarta;
        }

        public string toString()
        {
            return (idCarta + ") " + valore + " di " + seme);
        }
    }
}
