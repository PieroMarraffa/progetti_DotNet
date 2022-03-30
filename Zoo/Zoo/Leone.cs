using System;
namespace Zoo
{
    public class Leone : IAnimale
    {
        private string nome;
        private bool mangia, dorme, ruggisce;
        public Leone(string Nome)
        {
            this.nome = Nome;
        }

        public void Dorme()
        {
            this.dorme = true;
            this.mangia = false;
            this.ruggisce = false;
        }

        public void Mangia()
        {
            this.dorme = false;
            this.mangia = true;
            this.ruggisce = false;
        }

        public void Ruggisce()
        {
            this.dorme = false;
            this.mangia = false;
            this.ruggisce = true;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getAzione()
        {
            if (ruggisce)
            {
                return "il leone " + this.nome + " sta ruggendo";
            }
            else if (dorme)
            {
                return "il leone " + this.nome + " sta dormendo";
            }
            else
            {
                return "il leone " + this.nome + " sta mangiando";
            }
        }

    }
}
