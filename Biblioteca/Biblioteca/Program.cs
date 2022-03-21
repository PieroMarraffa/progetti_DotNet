using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BENVENUTO NELLA BIBLIOTECA COMUNALE!!!");
            Libro[] libri = GestioneBiblioteca.InizializzaBiblio();
            int sceltaOpzione = 1;

            while (sceltaOpzione != 0)
            {
                sceltaOpzione = GestioneBiblioteca.sceltaOpzione();
                switch (sceltaOpzione)
                {
                    case 0:
                        {
                            Console.WriteLine("ARRIVEDERCI!!!");
                            sceltaOpzione = 0;
                        };
                        break;

                    case 1:
                        {
                            libri = GestioneBiblioteca.inserisciLibro(libri);
                        };
                        break;

                    case 2:
                        {
                            GestioneBiblioteca.ricercaLibroTitolo(libri);
                        };
                        break;

                    case 3:
                        {
                            GestioneBiblioteca.ricercaLibriAutori(libri);
                        };
                        break;
                }
            }
        }
    }
}
