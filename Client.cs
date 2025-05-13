using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Client : Personne, IComparable<Client>, IPersonne
    {
        private string ville;

        // Constructeur :
        public Client(string ss, string nom, string prenom, DateTime naissance, string adresse, string mail, string telephone, string ville) : base(ss, nom, prenom, naissance, adresse, mail, telephone)
        {
            this.ville = ville;
        }

        // Propriétes :

        public string Ville
        {
            get { return ville; }
        }

        // Fonctions :

        /// <summary>
        /// Permet de modifier les informations d'une instance de client avec les informatiosn données
        /// </summary>
       
        public void Edit(string ss, string nom, string prenom, DateTime naissance, string adresse, string mail, string telephone, string ville)
        {
            this.ss = ss;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.naissance = naissance;
            this.adresse = adresse;
            this.mail = mail;
            this.telephone = telephone;
            this.ville = ville;
        }

        /// <summary>
        ///Permet de comparer des clients et de les trier par ordre alphabétique sur les noms
        /// </summary>
        /// <param name="client">Client à comparer</param>
        /// <returns></returns>
        
        public int CompareTo(Client client)
        {
            return this.nom.CompareTo(client.Nom);
        }

        /// <summary>
        /// Affiche les informations d'un client
        /// </summary>

        public override string ToString()
        {
            return base.ToString() + " - " + ville;
        }

    }
}
