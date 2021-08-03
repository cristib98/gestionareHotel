using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    class Camera
    {

        private int nrCamera;
        private string tipCamera;
        private bool disponibilitate;

        public Camera()
        {
            nrCamera = 0;
            tipCamera = "-";
            disponibilitate = false;
        }

        public Camera(int nr, string tip, bool disp)
        {
            nrCamera = nr;
            tipCamera = tip;
            disponibilitate = disp;
        }

        public int NrCamera
        {
            get { return nrCamera; }
            set
            {
                if (value > 0) nrCamera = value;
            }
        }

        public string TipCamera
        {
            get { return tipCamera; }
            set
            {
                tipCamera = value;
            }
        }

        public bool Disponibilitate
        {
            get { return disponibilitate; }
            set
            {
                 disponibilitate = value;
            }
        }

   

        public override string ToString()
        {
            string s;
            if (disponibilitate == true)
                s = "Da";
            else s = "Nu";
            return "Camera Nr. " + nrCamera + " - Tip: " + tipCamera + " Disponibilitate: " + s;
        }




    }
}
