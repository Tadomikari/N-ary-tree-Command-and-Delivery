using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class CamionBenne : Camion
    {
        private string type = "Camion Benne";
        private int nombrebennes;
        private bool grue;

        // Constructeur :

        public CamionBenne(List<string> matières, double volume, int nombrebennes, bool grue) : base(matières, volume)
        {
            this.nombrebennes = nombrebennes;
            this.grue = grue;
        }

        // Propriétes : 

        public int Nombrebennes
        {
            get { return nombrebennes; }
        }

        public bool Grue
        {
            get { return grue; }
        }

        // Fonctions :

        /// <summary>
        /// Affichage des informations du camion benne
        /// </summary>
        
        public override string ToString()
        {
            return type + " / Volume : " + volume + " Bennes : " + nombrebennes + " grue : " + grue;
        }
    }
}
