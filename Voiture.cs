using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Voiture : Vehicule
    {
        private string type = "Voiture";
        private int nombrepassagers;

        // Constructeur :
        public Voiture(int nombrepassagers) : base()
        {
            this.nombrepassagers = nombrepassagers;
        }

        // Propriétés : 

        public int Nombrepassagers
        {
            get { return nombrepassagers; }
        }

        // Fonctions :

        public override string ToString()
        {
            return type + " / Nombre de places : " + nombrepassagers;
        }

    }
}
