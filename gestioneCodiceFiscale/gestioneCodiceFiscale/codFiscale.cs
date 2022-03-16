using System;
namespace gestioneCodiceFiscale
{
    public class codFiscale
        //BY PIERO MARRAFFA 16-03-2022

    {
        // ATTRIBUTI
        private string cf;

        //CONSTRUCTOR, GETTERS AND SETTERS
        public codFiscale()
        {
        }

        public codFiscale(string cod)
        {
            this.cf = cod.ToUpper();
        }

        public string getCodFiscale()
        {
            return this.cf;
        }

        public void setCodFiscale(string cod)
        {
            this.cf = cod.ToUpper();
        }

        // OTHER METODS (MRRPRI99T24A345X)

        //IL CODICE FISCALE DEVE ESSERE DI 16 CIFRE
        public bool goodLenght()
        {
            if(this.cf.Length == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //PER STUDIARE LA DATA DI NASCITA VADO A UTILIZZARE LE REGOLE DATE
        public string getBirthDate()
        {
            int dayBirth = int.Parse(this.cf.Substring(9, 2));
            if (dayBirth > 40)
            {
                dayBirth = dayBirth - 40;
            }

            string yearBirth = this.cf.Substring(6, 2);
            int yearBirthCipher = int.Parse(yearBirth);

            if(yearBirthCipher < 30)
            {
                yearBirthCipher = yearBirthCipher + 2000;
            }
            else
            {
                yearBirthCipher = yearBirthCipher + 1900;
            }

            string monthBirth = this.cf.Substring(8, 1);
            if(monthBirth == "A")
            {
                monthBirth = "Genuary";
            }
            else if(monthBirth == "B")
            {
                monthBirth = "February";
            }
            else if(monthBirth == "C")
            {
                monthBirth = "March";
            }
            else if(monthBirth == "D")
            {
                monthBirth = "April";
            }
            else if(monthBirth == "E")
            {
                monthBirth = "May";
            }
            else if (monthBirth == "H")
            {
                monthBirth = "June";
            }
            else if(monthBirth == "L")
            {
                monthBirth = "July";
            }
            else if(monthBirth == "M")
            {
                monthBirth = "August";
            }
            else if(monthBirth == "P")
            {
                monthBirth = "September";
            }
            else if(monthBirth == "R")
            {
                monthBirth = "October";
            }
            else if (monthBirth == "S")
            {
                monthBirth = "November";
            }
            else if (monthBirth == "T")
            {
                monthBirth = "December";
            }

            return "your birth date is: " + dayBirth + monthBirth + yearBirth;

        }

        //PER STUDIARE L'ETÀ DEVO ANDARE A CONFRONTARE LA DATA DI NASCITA CON IL GIORNO ODIERNO
        //SE MESE O GIORNO DI NASCITA SONO MINORI O UGUALI ALL'ODIERNO ALLORA L'ETÀ SARÀ L'ANNO ODIERNO - L'ANNO DI NASCITA
        //SE IL MESE O IL GIORNO DI NASCITA SONO MAGGIORI ALL'ODIERNO ALLORA L'ETÀ È ANNO ODIERNO - ANNO DI NASCITA - 1
        public string getAge(string today)
        {
            int day = int.Parse(today.Substring(0, 2));
            int month = int.Parse(today.Substring(3, 2));
            int year = int.Parse(today.Substring(5, 4));

            int dayBirth = int.Parse(this.cf.Substring(9, 2));
            if (dayBirth > 40)
            {
                dayBirth = dayBirth - 40;
            }

            int yearBirth = int.Parse(this.cf.Substring(6, 2));

            if (yearBirth < 30)
            {
                yearBirth = yearBirth + 2000;
            }
            else
            {
                yearBirth = yearBirth + 1900;
            }

            string monthBirth = this.cf.Substring(8, 2);
            int monthBirthCipher = 0;
            if (monthBirth == "A")
            {
                monthBirthCipher = 1;
            }
            else if (monthBirth == "B")
            {
                monthBirthCipher = 2;
            }
            else if (monthBirth == "C")
            {
                monthBirthCipher = 3;
            }
            else if (monthBirth == "D")
            {
                monthBirthCipher = 4;
            }
            else if (monthBirth == "E")
            {
                monthBirthCipher = 5;
            }
            else if (monthBirth == "H")
            {
                monthBirthCipher = 6;
            }
            else if (monthBirth == "L")
            {
                monthBirthCipher = 7;
            }
            else if (monthBirth == "M")
            {
                monthBirthCipher = 8;
            }
            else if (monthBirth == "P")
            {
                monthBirthCipher = 9;
            }
            else if (monthBirth == "R")
            {
                monthBirthCipher = 10;
            }
            else if (monthBirth == "S")
            {
                monthBirthCipher = 11;
            }
            else if (monthBirth == "T")
            {
                monthBirthCipher = 12;
            }

            int age;
            if (month < monthBirthCipher || (month == monthBirthCipher && day >= dayBirth))
            {
                age = year - yearBirth;
            } else
            {
                age = year - yearBirth - 1;
            }

            return "the age is: " + age + " years";
        }


        // PER STUDIARE IL GENERE VADO A VESERE SE IL GIORNO DI NASCITA È MAGGIORE O MINORE DI 40
        public string getGender()
        {
            int dayBirth = int.Parse(this.cf.Substring(9, 2));
            if (dayBirth > 40)
            {
                return "gender is: FEMALE";
            }
            else
            {
                return "gender is: MALE";
            }
        }
    }
}
