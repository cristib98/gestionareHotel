using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Rezervari : INrOre
    {
        private int idRezervare;
        private int nrCamera;
        private int idClient;
        private DateTime checkin;
        private DateTime checkout;

        public Rezervari()
        {
            idRezervare = 0;
            nrCamera = 0;
            idClient = 0;
            checkin = DateTime.Now;
            checkout = DateTime.Now;
        }

        public Rezervari(int idR, int nr, int idC, DateTime ci, DateTime co)
        {
            idRezervare = idR;
            nrCamera = nr;
            idClient = idC;
            checkin = ci;
            checkout = co;
           
        }


        public int IdRezervare
        {
            get { return idRezervare; }
            set
            {
                if (value > 0) idRezervare = value;
            }
        }

        public int NrCamera
        {
            get { return nrCamera; }
            set
            {
                if (value > 0) nrCamera = value;
            }
        }
        
        public int IdClient
        {
            get { return idClient; }
            set
            {
                if (value > 0) idClient = value;
            }
        }


        public DateTime CheckIn
        {
            get { return checkin; }
            set { checkin = value; }
        }
        public DateTime CheckOut
        {
            get { return checkout; }
            set { checkout = value; }
        }

       

     

        //public int CalculeazaNrOre()
        //{
        //    return (int)this;
        //}


        public override string ToString()
        {
            string result = "ID rezervare = " + idRezervare + ", ID Client = " + IdClient + ", Numar camera = " + nrCamera + ", Check-In: " + checkin + ", Check-Out: " + checkout;
           
            return result;
        }
        
        public int pretTotal(int a)
        {
            
            if (File.Exists(@"Preturi.txt"))
            {
               
                string firstLine = File.ReadLines("Preturi.txt").FirstOrDefault();
                if (a == 1) return (checkout - checkin).Days * Convert.ToInt32(firstLine.Split(' ')[0]); 
                else if (a == 2) return (checkout - checkin).Days * Convert.ToInt32(firstLine.Split(' ')[1]);
                else if (a == 3) return (checkout - checkin).Days * Convert.ToInt32(firstLine.Split(' ')[2]);
                
           
            }
            return 0;
        }

        public int CalculeazaNrOre()
        {
            return Convert.ToInt32((checkout - checkin).TotalHours);
        }
    }
}
