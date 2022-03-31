using System;

namespace DelegatiNET
{
    class MainClass
    {
        delegate int Calcolatore(int a, int b);

        public static void Main(string[] args)
        {
            /*
             * ora vado a vedere tutti i delegati predefiniti che sono:
             * 
             * 1. DELEGATE INT Calcolatore(inta a, int b)
             *      è il delegato classico definito dal programmatore
             *      
             * 2. FUNC
             *      è un delegato definito in NET e non devo dichiararlo come prima (riga 7), 
             *      questo si aspetta n tipi generici. L'ultimo è il valore di ritorno, i primi due sono quelli di ingresso
             *      
             * 3. FUNC CON DELEGATO ANONIMO
             *      è utile perché definisco il codice direttamente in prossimità del delegato che può 
             *      tornare utile per l'organizzazione dello sviluppatore
             *      
             * 4. FUNC CON LAMBDA EXPRESSION
             *      forma contratta
             *      
             * 5. ACTION
             *      è come Func ma senza parametri in uscita (fino a 15 in ingresso)
             *      
             *  6. ACTION CONTRATTO
             *      è più veloce e contratto
             *      
             *  7. ACTION CON DELEGATO ANONIMO
             *      come al 3
             *      
             *  8. ACTION IN LAMBDA EXPRESSION
             *  
             *  9. PREDICATE
             *       è un caso di func che da in uscita il bool visto che è un caso molto frequente
             */


            //111111
            Calcolatore Somma = Aggiungi;
            int a = Somma(2, 3);



            // 222222
            Func<int, int, int> Somma2 = Aggiungi;
            int b = Somma2(7, 8);



            //3333333
            Func<int> dammiCasualeAnonimo = delegate ()
            {
                Random random = new Random(DateTime.Now.Millisecond);
                return random.Next(100);
            };
            b = dammiCasualeAnonimo();



            //444444
            Func<int> dammiCasualeLambda = () => new Random(DateTime.Now.Millisecond).Next(100);
            b = dammiCasualeLambda();



            //5555555
            Action<string> print = Printer;
            print("Mario");


            // 666666666
            Action<string> print2 = new Action<string>(Printer);


            //777777
            Action<string> print3 = delegate (string str){
                Console.WriteLine(str);
            };


            //88888
            Action<string> print4 = (str) => Console.WriteLine(str);


            //99999
            Predicate<string> predicate = Maiuscolo;
            bool maiuscolo = predicate("PIPPO");
        }



        //METODI DI APPOGGIO

        //per la FUNC
        public static int Aggiungi(int a, int b)
        {
            return (a + b);
        }

        //per la ACTION
        public static void Printer(string nome)
        {
            Console.WriteLine("ciau belu, ciau " + nome);
        }

        //per la PREDICATE
        public static bool Maiuscolo(string str)
        {
            return str.Equals(str.ToUpper());
        }


    }
}
