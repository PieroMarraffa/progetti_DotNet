using System;
namespace EnnesimoProgetto2
{
    public class Calcolatrice
    {
        //Elenco Attributi
        private double num1, num2;

        //Elenco MEtodi

        //Getter and Setter
        public void setNum1 (double numero1)
        {
             this.num1 = numero1;
        }

        public void setNum2(double numero2)
        {
            this.num2 = numero2;
        }

        public double getNum1()
        {
            return num1;
        }

        public double getNum2()
        {
            return num2;
        }

        //METODI UTILI

        public double somma(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public double differenza(double num1, double num2)
        {
            double diff = num1 - num2;
            return diff;
        }

        public double prodotto(double num1, double num2)
        {
            double product = num1 * num2;
            return product;
        }

        public double rapporto(double num1, double num2)
        {
            double quoziente = num1 / num2;
            return quoziente;
        }

        public double rapportoArrotondato(double num1, double num2)
        {
            double quoziente = num1 / num2;
            quoziente = Math.Round(quoziente, 3);
            return quoziente;
        }
    }
}
