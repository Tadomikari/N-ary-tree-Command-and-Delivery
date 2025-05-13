using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public abstract class Camion : Vehicule
    {
        protected List<string> matieres;
        protected double volume;

        // Constructeur :

        public Camion(List<string> matières, double volume) : base() 
        {
         this.matieres = matières;
         this.volume = volume;
        }

        // Propriétés : 

        public List<string> Matieres
        {
            get { return this.matieres; }
        }

        public double Volume
        {
            get { return this.volume; }
        }
    }
}
