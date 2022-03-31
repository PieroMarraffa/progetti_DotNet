using System;
namespace Strutture
{
    public struct Rettangolo
    {
        public int Base;
        public int Altezza;

        public Rettangolo(int a, int b)
        {
            this.Altezza = a;
            this.Base = b;
        }

        public int Area()
        {
            return (Base * Altezza);
        }
    }
}