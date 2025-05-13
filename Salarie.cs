using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Salarie : Personne, IPersonne
    {
        private DateTime entree;
        private string poste;
        private double salaire;


        // Constructeur :
        public Salarie(string ss, string nom, string prenom, DateTime naissance, string adresse, string mail, string telephone, DateTime entree, string poste, double salaire) : base(ss, nom, prenom, naissance, adresse, mail, telephone)
        {
            this.entree = entree;
            this.poste = poste;
            this.salaire = salaire;
        }

        // Propriétes :

        public DateTime Entree
        {
            get { return this.entree; }
        }

        public string Poste
        {
            get { return this.poste; } 
            set { this.poste = value; } // Seuls certains attributs sont modifiables selon l'énoncé
        }

        public double Salaire
        {
            get { return this.salaire; }
            set { this.salaire = value;}
        }

        // Fonctions :

        /// <summary>
        /// Affiche les informations d'un salarié
        /// </summary>

        public override string ToString()
        {
            return base.ToString() + " - " + entree.ToShortDateString() + " - " + poste + " - " + salaire;
        }
    }
}
