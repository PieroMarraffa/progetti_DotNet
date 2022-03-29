using System;
namespace PrestiFastFinanziaria
{
    public class Prestito
    {
        //ATTRIBUTI
        private int idPrestito, nRate;
        private double importo;
        private bool esito;
        private string dataAttivazione, dataRichiesta;
        private Persona persona;


        //CONST, GETTER & SETTER
        public Prestito()
        {
        }

        public Prestito(int IdPrestito, int NRate, double Importo, bool Esito, string DataAttivazione, string DataRichiesta, Persona Persona)
        {
            this.idPrestito = IdPrestito;
            this.nRate = NRate;
            this.importo = Importo;
            this.esito = Esito;
            this.dataAttivazione = DataAttivazione;
            this.dataRichiesta = DataRichiesta;
            this.persona = Persona;
        }

        public int getIdPrestito()
        {
            return this.idPrestito;
        }

        public int getNRate()
        {
            return this.nRate;
        }

        public double getImporto()
        {
            return this.importo;
        }

        public bool getEsito()
        {
            return this.esito;
        }

        public string getDataAttivazione()
        {
            return this.dataAttivazione;
        }

        public string getDataRichiesta()
        {
            return this.dataRichiesta;
        }

        public Persona getPersona()
        {
            return this.persona;
        }

        public void setIdPrestito(int IdPrestito)
        {
            this.idPrestito = IdPrestito;
        }

        public void setNRate(int NRate)
        {
            this.nRate = NRate;
        }

        public void setImporto(double Importo)
        {
            this.importo = Importo;
        }

        public void setEsito(bool Esito)
        {
            this.esito = Esito;
        }

        public void setDataAttivazione(string DataAttivazione)
        {
            this.dataAttivazione = DataAttivazione;
        }

        public void setDataRichiesta(string DataRichiesta)
        {
            this.dataRichiesta = DataRichiesta;
        }

        public void setPersona(Persona Persona)
        {
            this.persona = Persona;
        }

        //METODI DI GESTIONE
        public string toString()
        {
            return ("Il prestito è stato richiesto da: " + this.persona.toString() + " in data: " + this.dataRichiesta + " per un ammontare di: " + this.importo + " da pagare in: " + this.nRate + " rate. Il prestito è stato attivato in data: " + this.dataAttivazione);
        }
    }
}
