using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class CamionFrigo : Camion
    {
        private string type = "Camion Frigorifique";
        private int nombregroupelectrogenes;

        // Constructeur :

        public CamionFrigo(List<string> matières, double volume, int nombregroupelectrogenes) : base(matières, volume)
        {
            this.nombregroupelectrogenes = nombregroupelectrogenes;
        }

        // Propriétes : 

        public int Nombregroupelectrogene
        {
            get { return nombregroupelectrogenes; }
        }

        // Fonctions :

        /// <summary>
        /// Affichage des informations du camion frigorifique
        /// </summary>
        
        public override string ToString()
        {
            return type + " / Volume : " + volume + " Groupes électrogènes : " + nombregroupelectrogenes;
        }
    }
}
