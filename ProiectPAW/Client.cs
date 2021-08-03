using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
   public class Client: Persoana, ICloneable, IComparable

    {
        private int idClient;
        private string nationalitate;
        private string nrTelefon;

        public Client() : base()
        {
            idClient = 0;
            nationalitate = "-";
            nrTelefon = "-";
        }

        public Client(string n, string p, char s, int id, string nat, string nr): base(n, p, s)
        {
            idClient = id;
            nationalitate = nat;
            nrTelefon = nr;
        }

        public int IdClient
        {
            get { return idClient; }
            set
            {
                if (value > 0) idClient = value;
            }
        }

        public string Nationalitate
        {
            get { return nationalitate; }
            set
            {
                nationalitate = value; // IF
            }
        }

        public string NrTelefon
        {
            get { return nrTelefon; }
            set
            {
                nrTelefon = value; // IF
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Client c = (Client)obj;
            if (this.idClient < c.idClient)
                return -1;
            else
                if (this.idClient > c.idClient)
                return 1;
            else return string.Compare(this.Nume, c.Nume);
        }

        public override string ToString()
        {
            return "ID client: " + idClient + " - "+ base.ToString() + ". Naționalitate - " + nationalitate +". Număr de telefon: "+nrTelefon;

        }
    }
}
