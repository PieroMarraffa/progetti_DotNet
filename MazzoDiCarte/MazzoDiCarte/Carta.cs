using System;
namespace MazzoDiCarte
{
    public class Carta
    {
        string valore, seme;

        public Carta()
        {
        }

        public Carta(string Valore, string Seme)
        {
            this.valore = Valore;
            this.seme = Seme;
        }

        public string toString()
        {
            return (valore + " di " + seme);
        }
    }
}
