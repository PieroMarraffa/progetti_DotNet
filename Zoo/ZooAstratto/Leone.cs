using System;
namespace ZooAstratto
{
    public class Leone : AZoo
    {
        public Leone(string Nome) : base(Nome)
        { }

        public override string getAzione()
        {
            if (base.azione)
            {
                return "il leone " + base.nome + " sta ruggendo";
            }
            else if (base.dorme)
            {
                return "il leone " + base.nome + " sta dormendo";
            }
            else
            {
                return "il leone " + base.nome + " sta mangiando";
            }
        }
    }
}
