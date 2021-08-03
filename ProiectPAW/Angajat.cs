using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Angajat: Persoana, ICloneable, IComparable
    {

        private int idAngajat;
        private float salariu;
       

        public Angajat() : base()
        {
            idAngajat = 0;
            salariu = 0;
   
        }

        public Angajat(string n, string p, char s, int id, float sal) : base(n, p, s)
        {
            idAngajat = id;
            salariu = sal;
          
        }

        public int IdAngajat
        {
            get { return idAngajat; }
            set
            {
                if (value > 0) idAngajat = value;
            }
        }

        public float Salariu
        {
            get { return salariu; }
            set
            {
                if (value > 100) salariu = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Angajat a = (Angajat)obj;
            if (this.salariu < a.salariu)
                return -1;
            else
                if (this.salariu > a.salariu)
                return 1;
            else return string.Compare(this.Nume, a.Nume);
        }

        public override string ToString()
        {
            return "ID Angajat: "+idAngajat+" - "+ base.ToString()+" Salariul = " + salariu+" lei";
        }

        //public string ToString2()
        //{
        //    return Nume + " " + Prenume + " (ID " + idAngajat + "). " + " Salariul - " + salariu + " lei.";
        //}


    }
}
