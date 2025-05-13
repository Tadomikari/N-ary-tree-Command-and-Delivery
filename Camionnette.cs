using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Camionnette : Vehicule
    {
        private string type = "Camionnette";
        private string usage;

        // Constructeur :
        public Camionnette(string usage) : base()
        {
            this.usage= usage;
        }

        // Propriétés : 

        public string Usage
        {
            get { return usage; }
        }

        // Fonctions :

        /// <summary>
        /// Affichage des informations de la Camionette
        /// </summary>
        
        public override string ToString()
        {
            return type + " / Usage : " + usage;
        }
    }
}
