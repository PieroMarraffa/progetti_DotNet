using System;
namespace MetodiDiEstensione
{
    static class MyString
    {

        /*QUESTA CLASSE CONTIENE DEI METODI DI ESTENSIONI.
         * DEVE RISPETTARE DELLE REGOLE:
         * 1. DEVE ESSERE STATIC
         * 2. PUÒ CHIAMARSI IN QUALUNQUE MODO
         * 3. INSERISCO IL "this string" PER AVVISARE COMPILATORE E INTELLISENSE CHE FARÀ
         *      PARTE DEI METODI DI String
         */
        public static string toMaiuscolo(this string val)
        {
            return val.ToUpper();
        }

        //NE POSSO AGGIUNGERE ANCHE UNA PER LA CLASSE Integer
        public static double divisoPerDue(this int val)
        {
            return (val / 2);
        }
    }
}
