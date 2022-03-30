using System;
namespace ZooAstratto
{
    public abstract class AZoo
    {
        protected string nome;
        protected bool mangia, dorme, azione;
        public AZoo(string Nome)
        {
            this.nome = Nome;
        }

        public void Mangia()
        {
            this.mangia = true;
            this.dorme = false;
            this.azione = false;
        }

        public void Dorme()
        {
            this.mangia = false;
            this.dorme = true;
            this.azione = false;
        }

        public void Azione()
        {
            this.mangia = false;
            this.dorme = false;
            this.azione = true;
        }

        public virtual string getAzione() {
            return "";
        }
    }
}
