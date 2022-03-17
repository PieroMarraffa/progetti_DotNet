using System;
namespace BancomatSimulator
{
    public class gestioneBancomat
    {
        //CREAZIONE ATTRIBUTI
        private int conto, pin;

        //COSTRUTTORE, GETTER E SETTER
        public gestioneBancomat()
        {

        }

        public gestioneBancomat (int conto, int pin)
        {
            this.conto = conto;
            this.pin = pin;
        }

        public int getConto()
        {
            return this.conto;
        }

        public int getPin()
        {
            return this.pin;
        }

        public void setConto(int c)
        {
            this.conto = c;
        }

        public void setPin(int pin)
        {
            this.pin = pin;
        }

        //METODI DI GESTIONE DELL'OGGETTO

        //metodo per la verifica del pin inserito
        public bool verifyAccess(int toVerify)
        {
            if(toVerify == this.pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodo per il prelievo dal conto
        public int withdraw(int amount)
        {
            int success = 0;
            if(amount > this.conto)
            {
                success = 1;
            }
            else if(amount > 250)
            {
                success = 2;
            }
            else
            {
                this.conto = this.conto - amount;
            }
            return success;
        }

        //metodo per il versamento
        public void deposit(int amount)
        {
            this.conto = this.conto + amount;
        }

    }
}
