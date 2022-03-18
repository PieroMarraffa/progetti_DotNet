using System;
namespace CAF
{
    public class Person
    {
        //DICIARAZIONE ATTRIBUTI
        private string nome, cognome, sesso;
        private int eta, anniLavorativi, anniLavorativiUltimaOccupazione;
        private double isee, patrimonioImmobiliare, redditoAnnuo, ultimaBustaPagaNetta;

        //CONSTRUCTOR, GETTER E SETTER
        public Person()
        {
        }

        public Person(string Nome, string Cognome, string Sesso, int Eta, int AnniLavorativi, int AnniLavorativiUltimaOccupazione, double Isee, double PatrimonioImmobiliare, double RedditoAnnuo, double UltimaBustaPagaNetta)
        {
            this.nome = Nome;
            this.cognome = Cognome;
            this.sesso = Sesso;
            this.eta = Eta;
            this.anniLavorativi = AnniLavorativi;
            this.anniLavorativiUltimaOccupazione = AnniLavorativiUltimaOccupazione;
            this.isee = Isee;
            this.patrimonioImmobiliare = PatrimonioImmobiliare;
            this.redditoAnnuo = RedditoAnnuo;
            this.ultimaBustaPagaNetta = UltimaBustaPagaNetta;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public string getSesso()
        {
            return this.sesso;
        }

        public int getEta()
        {
            return this.eta;
        }

        public int getAnniLavorativi()
        {
            return this.anniLavorativi;
        }

        public int getAnniLavorativiUltimaOccupazione()
        {
            return this.anniLavorativiUltimaOccupazione;
        }

        public double getIsee()
        {
            return this.isee;
        }

        public double getPatrimonioImmobiliare()
        {
            return this.patrimonioImmobiliare;
        }

        public double getReddito()
        {
            return this.redditoAnnuo;
        }

        public double getUltimaBustaPagaNetta()
        {
            return this.ultimaBustaPagaNetta;
        }

        public void setNome(string Nome)
        {
            this.nome = Nome;
        }

        public void setCognome(string Cognome)
        {
            this.cognome = Cognome;
        }

        public void setSesso(string Sesso)
        {
            this.sesso = Sesso;
        }

        public void setEta(int Eta)
        {
            this.eta = Eta;
        }

        public void setAnniLavorativi(int AnniLavorativi)
        {
            this.anniLavorativi = AnniLavorativi;
        }

        public void setAnniLavorativiUltimaOccupazione(int AnniLavorativiUltimaOccupazione)
        {
            this.anniLavorativiUltimaOccupazione = AnniLavorativiUltimaOccupazione;
        }

        public void setIsee(double Isee)
        {
            this.isee = Isee;
        }

        public void setPatrimonioImmobiliare(double PatrimonioImmobiliare)
        {
            this.patrimonioImmobiliare = PatrimonioImmobiliare;
        }

        public void setRedditoAnnuo( double RedditoAnnuo)
        {
            this.redditoAnnuo = RedditoAnnuo;
        }

        public void setUltimaBustaPagaNetta(double UltimaBustaPagaNetta)
        {
            this.ultimaBustaPagaNetta = UltimaBustaPagaNetta;
        }

        //METODI DI MODELLAZIONE
    }
}
