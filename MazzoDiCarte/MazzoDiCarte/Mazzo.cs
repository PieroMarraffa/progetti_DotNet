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

        public List<Carta> getMazzo()
        {
            return this.mazzo;
        }


        //SCANSIONO I DUE ENUMERATIVI PER ANDARE A CREARE LE CARTE
        public void costruisciMazzo()
        {
            int i = 0;
            foreach (var item in Enum.GetValues(typeof(Semi)))
            {
                foreach (var seme in Enum.GetValues(typeof(Valori)))
                {
                    Carta carta = new Carta(i, seme.ToString(), item.ToString());
                    this.mazzo.Add(carta);
                    i++;
                }
            }
        }

        //DATO IL MAZZO VADO A PRENDERE UNA DELLE CARTE AL SUO INTERNO
        //RANDOMICAMENTE E LA RIMUOVO DAL MAZZO STESSO.
        public Carta estraiCarta()
        {
            Random random = new Random();
            int posizione = random.Next(0, this.mazzo.Count);
            foreach(var item in mazzo)
            {
                if(item.getId() == posizione)
                {
                    this.mazzo.Remove(item);
                    return item;
                }
            }
            return new Carta();
        }

        //DATO IL MAZZO VADO A REINSERIRE  LE CARTE  ESTRATTE AL SUO INTERNO
        public void reinserisciCarte(List<Carta> mano)
        {
            foreach(var item in mano)
            {
                mazzo.Add(item);
            }
            sortMazzo();
        }


        public void sortMazzo()
        {
            List<Carta> mazzoNuovo = new List<Carta>();
            int i = 0;
            foreach(var item in this.mazzo)
            {
                if(item.getId() == i)
                {
                    mazzoNuovo.Add(item);
                }
            }
            this.mazzo = mazzoNuovo;
        }
    }
}
