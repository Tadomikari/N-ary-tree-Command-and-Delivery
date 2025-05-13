using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class CamionCiterne : Camion
    {
        private string type = "Camion Citerne";
        private string typeCuve;

        // Constructeur :

        public CamionCiterne(List<string> matières, double volume, string typeCuve) : base(matières, volume)
        {
            this.typeCuve = typeCuve;
        }

        // Propriétes : 

        public string Typecuve
        {
            get { return typeCuve; }
        }

        // Fonctions :

        /// <summary>
        /// Affichage des informations du camion citerne
        /// </summary>
        
        public override string ToString()
        {
            return type + " / Volume : " + volume + " Cuve : " +typeCuve;
        }
    }
}
