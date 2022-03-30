using System;
using System.Collections.Generic;

namespace MazzoDiCarte
{
    public class Mazzo
    {

        List<Carta> mazzo;

        public Mazzo()
        {
            mazzo = new List<Carta>();
        }


        //SCANSIONO I DUE ENUMERATIVI PER ANDARE A CREARE LE CARTE
        public void costruisciMazzo()
        {
            foreach (var item in Enum.GetValues(typeof(Semi)))
            {
                foreach (var seme in Enum.GetValues(typeof(Valori)))
                {
                    Carta carta = new Carta(seme.ToString(), item.ToString());
                    this.mazzo.Add(carta);
                }
            }
        }

        //DATO IL MAZZO VADO A PRENDERE UNA DELLE CARTE AL SUO INTERNO
        //RANDOMICAMENTE E LA RIMUOVO DAL MAZZO STESSO.
        public Carta estraiCarta()
        {
            Random random = new Random();
            int posizione = random.Next(0, this.mazzo.Count);
            Carta estratta = this.mazzo[posizione];
            this.mazzo.RemoveAt(posizione);
            return estratta;
        }
    }
}
