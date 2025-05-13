using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Noeud // noeud d'un arbre N-aire
    {
        private Salarie salarie;
        private Noeud successeur;
        private Noeud frere;

        // Constructeur :

        public Noeud(Salarie salarie)
        {
            this.salarie = salarie;
            this.successeur = null;
            this.frere = null;
        }

        // Propriétes : 

        public Salarie Salarie
        {
            get { return salarie; }
        }

        public Noeud Successeur
        {
            get { return successeur; }
            set { successeur = value; }
        }

        public Noeud Frere
        {
            get { return frere; }
            set { frere = value; }
        }
    }
}
