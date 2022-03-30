using System;
namespace ZooAstratto
{
    public class Gazella : AZoo
    {
        public Gazella(string Nome) : base(Nome)
        {
        }

        public override string getAzione()
        {
            if (base.azione)
            {
                return "la gazella " + base.nome + " sta scappando";
            }
            else if (base.dorme)
            {
                return "la gazella " + base.nome + " sta dormendo";
            }
            else
            {
                return "la gazella " + base.nome + " sta mangiando";
            }
        }
    }
}
