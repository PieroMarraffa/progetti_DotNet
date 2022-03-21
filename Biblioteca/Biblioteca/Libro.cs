using System;
namespace Biblioteca
{
    public class Libro
    {

        //DICHIARAZIONE ATTRIBUTI
        private string titolo, autore, editore;
        private int annoPubblicazione, scaffale, piano;


        //CONSTR, GETTER AND SETTER
        public Libro()
        {
        }

        public Libro(string Titolo, string Autore, string Editore, int AnnoPubblicazione, int Scaffale, int Piano )
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.editore = Editore;
            this.annoPubblicazione = AnnoPubblicazione;
            this.scaffale = Scaffale;
            this.piano = Piano;
        }

        public string getTitolo()
        {
            return this.titolo;
        }

        public string getAutore()
        {
            return this.autore;
        }

        public string getEditore()
        {
            return this.editore;
        }

        public int getAnnoPubb()
        {
            return this.annoPubblicazione;
        }

        public int getScaffale()
        {
            return this.scaffale;
        }

        public int getPiano()
        {
            return this.piano;
        }

        public void setTitolo(string Titolo)
        {
            this.titolo = Titolo;
        }

        public void setAutore(string Autore)
        {
            this.autore = Autore;
        }

        public void setEditore(string Editore)
        {
            this.editore = Editore;
        }

        public void setAnnoPubb(int AnnoPubb)
        {
            this.annoPubblicazione = AnnoPubb;
        }

        public void setScaffale(int Scaffale)
        {
            this.scaffale =Scaffale;
        }

        public void setPiano(int Piano)
        {
            this.piano = Piano;
        }


        //METODI DI GESTIONE

        public bool ricercaTitolo(string subString)
        {
            if (titolo.IndexOf(subString) != -1)
            {
                return true;
            }
            else return false;
        }

        public bool ricercaAutore(string Autore)
        {
            if (autore.IndexOf(Autore) != -1)
            {
                return true;
            }
            else return false;
        }

        public string toString()
        {
            return "titolo: " + titolo + "   autore: " + autore + "   editore: " + editore + "   anno di pubblicazione: " + annoPubblicazione + "   scaffale: " + scaffale + "   piano: " + piano;
        }
    }
}
