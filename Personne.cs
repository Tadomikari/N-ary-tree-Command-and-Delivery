using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Personne
    {
        protected string ss;
        protected string nom;
        protected string prenom;
        protected DateTime naissance;
        protected string adresse;
        protected string mail;
        protected string telephone;


        // Constructeur :

        public Personne(string ss, string nom, string prenom, DateTime naissance, string adresse, string mail, string telephone) 
        { 
            this.ss = ss;
            this.nom = nom;
            this.prenom = prenom;
            this.naissance = naissance;
            this.adresse = adresse;
            this.mail = mail;
            this.telephone = telephone;    
        }

        // Propriétes :

        public string SS
        {
            get { return this.ss; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; } // Seuls certains attributs sont modifiables selon l'énoncé
        }
        public string Prenom
        {
            get { return this.prenom; }
        }
        public DateTime Naissance
        {
            get { return this.naissance; }
        }
        public string Adresse
        {
            get { return this.adresse; }
            set { this.adresse = value;}
        }
        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }
        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }

        // Fonctions :

        /// <summary>
        /// Affiche les informations d'une personne
        /// </summary>

        public override string ToString()
        {
            return ss +" - "+ nom + " - " + prenom + " - " + naissance.ToShortDateString() + " - " + telephone;
        }
    }
}
