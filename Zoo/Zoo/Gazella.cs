using System;
namespace Zoo
{
    public class Gazella  : IAnimale
    {
        private string nome;
        bool dorme, mangia, scappa;

        public Gazella( string Nome)
        {
            this.nome = Nome;
        }

        public void Dorme()
        {
            this.dorme = true;
            this.mangia = false;
            this.scappa = false;
        }

        public void Mangia()
        {
            this.dorme = false;
            this.mangia = true;
            this.scappa = false;
        }

        public void Scappa()
        {
            this.dorme = false;
            this.mangia = false;
            this.scappa = true;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getAzione()
        {
            if (scappa)
            {
                return "la gazzella " + this.nome + " sta scappando";
            } else if (dorme)
            {
                return "la gazzella " + this.nome + " sta dormendo";
            } else
            {
                return "la gazzella " + this.nome + " sta mangiando";
            }
        }


    }
}
