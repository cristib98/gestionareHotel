using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
   public abstract class Persoana
    {
        private string nume;
        private string prenume;
        private char sex;

        public Persoana()
        {
            nume = "-";
            prenume = "-";
            sex = 'M';
        }

        public Persoana(string n, string p, char s)
        {
            nume = n;
            prenume = p;
            sex = s;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                 nume = value; //conditie 
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                prenume = value; //conditie 
            }
        }

        public char Sex
        {
            get { return sex; }

            set { sex = value; } //conditie
        }

        public override string ToString()
        {
            return nume+" " + prenume + ", sex - " + sex;
        }


    }
}
