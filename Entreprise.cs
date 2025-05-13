using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Entreprise
    {
        private string nom;
        private List<Client> clients;
        private List<Vehicule> vehicules;
        private List<Commande> commandes;
        private Noeud root; // Racine de l'organigramme ( arbre N-aire )

        // Constructeurs :

        public Entreprise(string nom, List<Client> clients, List<Vehicule> vehicules, List<Commande> commandes) 
        { 
            this.nom = nom;
            this.clients = clients;
            this.vehicules= vehicules;
            this.commandes = commandes;
            this.root = null;
        }

        // Constructeur pour créer une entreprise vide :

        public Entreprise(string nom)
        {
            this.nom = nom;
            this.clients = new List<Client>();
            this.vehicules = new List<Vehicule>();
            this.commandes = new List<Commande>();
            this.root = null;
        }

        // Propriétes :

        public string Nom
        {
            get { return nom; }
        }

        public List<Client> Clients
        {
            get { return clients; }
        }

        public List<Vehicule> Vehicules
        {
            get { return vehicules; }
        }

        public List<Commande> Commandes
        {
            get { return commandes; }
        }
        public Noeud Salaries
        {
            get { return this.root; }
        }

        // Fonctions :

        /// <summary>
        /// Ajoute le salarié "enfant" sous le salarié "parent" de l'arbre N-aire
        /// Si un enfant est déjà présent, alors un frère sera alors crée
        /// </summary>
        /// <param name="parent">Le salarié parent</param>
        /// <param name="enfant">Le salarié enfant</param>

        public void Ajouter(Salarie parent, Salarie enfant)
        {
            if (root == null)
            {
                root = new Noeud(enfant); // Si pas de racine, on ajoute l'enfant en tant que racine
                return;
            }
            if (parent == null)
            {
                Console.WriteLine("Erreur : Parent null"); // Vérification null
                return;
            }

            Noeud ParentN = TrouverN(parent); // On cherche le noeud correspondant au  parent

            if (ParentN == null)
            {
                Console.WriteLine("Le salarié n'a pas été trouvé dans l'organigramme !");
                return;
            }

            if (ParentN.Successeur == null) ParentN.Successeur = new Noeud(enfant); // On ajoute le salarié en tant qu'enfant s'il est seul
            else
            {
                Noeud dernierFrere = ParentN.Successeur;
                while (dernierFrere.Frere != null)
                {
                    dernierFrere = dernierFrere.Frere;
                }
                dernierFrere.Frere = new Noeud(enfant); // Sinon, on l'ajoute en tant que frère
            }
        }

        /// <summary>
        /// Permet de trouver le noeud correspondant à un salarié dans l'arbre n-aire
        /// </summary>
        /// <param name="salarie">L'instance de salarié à trouver</param>

        public Noeud TrouverN(Salarie salarie)
        {
            if (root == null) return null;

            Stack<Noeud> pile = new Stack<Noeud>(); // Parcours de l'arbre en utilisant une pile
            pile.Push(root);

            while (pile.Count > 0)
            {
                Noeud current = pile.Pop();

                if (current.Salarie == salarie) return current;
                if (current.Frere != null) pile.Push(current.Frere);
                if (current.Successeur != null) pile.Push(current.Successeur);
            }
            return null;
        }

        /// <summary>
        /// Permet de trouver un salarié dans l'arbre n-aire grâce à son nom
        /// </summary>
        /// <param name="nom">Nom du salarié à trouver</param>

        public Salarie Trouver(string nom)
        {
            if (root == null) return null;

            Stack<Noeud> pile = new Stack<Noeud>(); // Parcours de l'arbre en utilisant une pile
            pile.Push(root);

            while (pile.Count > 0)
            {
                Noeud current = pile.Pop();

                if (current.Salarie.Nom.ToLower() == nom.ToLower()) return current.Salarie;
                if (current.Frere != null) pile.Push(current.Frere);
                if (current.Successeur != null) pile.Push(current.Successeur);
            }
            return null;
        }

        /// <summary>
        /// Permet d'afficher l'arbre N-aire sous forme d'organigramme
        /// </summary>
        /// <param name="noeud">Noeud à partir duquel commencer l'affichage</param>
        /// <param name="level">Niveau de profondeur pour représenter la chaine de commandement, à laisser vide !</param>

        public void Afficher(Noeud noeud, int level = 0)
        {
            if (noeud == null) return; // Condition d'arrêt

            // Affichage des flèches
            for (int i = 0; i < level - 1; i++)
            {
                Console.Write("  │");
            }

            if (noeud.Successeur == null && noeud.Frere == null) Console.Write("  └>");
            else if (level > 0) Console.Write("  ├>");


            Console.Write(noeud.Salarie.Nom);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" (" + noeud.Salarie.Poste + ")");
            Console.ForegroundColor = ConsoleColor.White;

            Afficher(noeud.Successeur, level + 1); // Affichage des successeurs
            Afficher(noeud.Frere, level); // Affichage des frères (tous au même niveau)
        }

        /// <summary>
        /// Permet de trouver le noeud parent d'un noeud donné
        /// </summary>
        /// <param name="noeud">Noeud dont nous cherchons le parent</param>
        /// <param name="current">Noeud de départ, initialiser à root</param>

        private Noeud TrouverParent(Noeud noeud, Noeud current)
        {
            if (current == null || noeud == null) return null; // Vérification null
            if (current.Successeur == noeud) return current; // Vérification successeur = nœud recherché

            Noeud temp = current.Successeur; // Vérification parmi les frères
            while (temp != null)
            {
                if (temp == noeud) return current;
                temp = temp.Frere;
            }

            temp = current.Successeur; // Puis recherche récursive dans les enfants
            while (temp != null)
            {
                Noeud parent = TrouverParent(noeud, temp);
                if (parent != null) return parent;
                temp = temp.Frere;
            }
            return null; // On retourne null si le parent n'est pas trouvé
        }

        /// <summary>
        /// Permet de trouver le frère précédant le noeud actuel
        /// </summary>
        /// <param name="employe">Noeud pour lequel on cherche son dernier frère</param>
        /// <param name="parent">Parent du noeud employe</param>

        public Noeud TrouverFrerePrecedent(Noeud employe, Noeud parent)
        {
            if (parent == null || employe == null) return null;

            Noeud frerePrecedent = parent.Successeur;

            // Si le nœud est le premier successeur, il n'y a pas de frère précédent
            if (frerePrecedent == employe)
                return null;

            while (frerePrecedent != null && frerePrecedent.Frere != employe)
            {
                frerePrecedent = frerePrecedent.Frere;
            }

            return frerePrecedent;
        }

        /// <summary>
        /// Permet de trouver le dernier frère d'un noeud
        /// </summary>
        /// <param name="noeud">Noeud dont on cherche le dernier frère</param>
        
        public Noeud TrouverDernierFrere(Noeud noeud)
        {
            if (noeud == null) return null;

            Noeud dernierFrere = null;
            Noeud frereCourant = noeud;

            while (frereCourant != null)
            {
                dernierFrere = frereCourant;
                frereCourant = frereCourant.Frere;
            }

            return dernierFrere;
        }


        /// <summary>
        /// Supprime le salarié avec le nom donné
        /// </summary>
        /// <param name="employe">Noeud de l'employé à supprimer</param>

        public void Supprimer(Noeud employe)
            {
                if (root == null || employe == null) return; // Vérification entrées

                if(employe == root) // Cas de la racine
                {
                    Console.WriteLine("Impossible de virer le Patron !");
                    Thread.Sleep(1500);
                    return;
                }

                Noeud parent = TrouverParent(employe, root);
                Noeud FrerePrecedent = TrouverFrerePrecedent(employe, parent);
                Noeud DernierFrere = TrouverDernierFrere(employe.Successeur);

            if (employe.Successeur == null && employe.Frere == null) // Cas pas de Frere ni de Sucesseur
                {
                if (FrerePrecedent == null) parent.Successeur = null;
                else FrerePrecedent.Frere = null;
                return;
                }

                if(employe.Successeur!= null && employe.Frere == null) // Cas pas de Frere mais Sucesseurs
                {
                if (FrerePrecedent == null) parent.Successeur = employe.Successeur;
                else FrerePrecedent.Frere = employe.Successeur;
                return;
                }
            
                if(employe.Successeur == null && employe.Frere != null) // Cas Frere mais pas de sucesseur
                {
                if (FrerePrecedent == null) parent.Successeur = employe.Frere;
                else FrerePrecedent.Frere = employe.Frere;
                return;
                }

                if (employe.Successeur != null && employe.Frere != null) // Cas Frere et Sucesseur
                {
                
                    if (FrerePrecedent == null) parent.Successeur = employe.Successeur;
                    else FrerePrecedent.Frere = employe.Successeur;
                    DernierFrere.Frere = employe.Frere;
                    return;
                }

            }

        /// <summary>
        /// Affiche tous les clients de l'entreprise
        /// </summary>

        public void AfficherClients()
        {
            foreach(Client c in this.Clients)
            {
                Console.WriteLine(c);
            }
        }

        /// <summary>
        /// Affiche tous les clients ainsi que leurs achats totaux
        /// </summary>

        public void AfficherClientsTotal()
        {
            foreach (Client c in this.Clients)
            {
                Console.WriteLine(c + " - " +TotalAchat(c) + " euros");
            }
        }

        /// <summary>
        /// Permet de trouver une commande dans l'entreprise
        /// </summary>
        /// <param name="chauffeur">Chauffeur qui à effectué la commande</param>
        /// <param name="date">Date de livraison de la commande</param>
        /// <returns></returns>

        public Commande ChercherCommande(int id)
        {
            return commandes.Find(c => c.Id == id);
        }

        /// <summary>
        /// Calcule le total des achats d'un client
        /// </summary>
        /// <param name="client">client dont on cherche le montant des achats</param>

        public double TotalAchat(Client client)
        {
            double res = 0;
            foreach (Commande c in commandes)
            {
                if (c.Client.SS == client.SS) res += c.Prix;
            }
            return res;
        }

        /// <summary>
        /// Sauvegarde l'entreprise dans un fichier Entreprise.txt
        /// </summary>
       
        public void Sauvegarder()
        {
            StringBuilder e = new StringBuilder();

            e.AppendLine("Nom de l'entreprise : " + nom);

            e.AppendLine("\nClients :\n"); // On ajoute les données de notre classe entreprise dans le fichier
            foreach (Client client in clients)
            {
                e.AppendLine(client.ToString());
            }

            e.AppendLine("\nVéhicules :\n");
            foreach (Vehicule vehicule in vehicules)
            {
                e.AppendLine(vehicule.ToString());
            }

            e.AppendLine("\nCommandes :\n");
            foreach (Commande commande in commandes)
            {
                e.AppendLine(commande.ToString());
            }

            e.AppendLine("\nOrganigramme :\n");
            SauvegarderArbre(e, root); // On écrit l'arbre n-aire

            File.WriteAllText("Entreprise.txt", e.ToString());
        }

        /// <summary>
        /// Sauvegarde l'arbre n-aire dans un fichier texte, de la même manière que pour son affichage
        /// </summary>
        
        private void SauvegarderArbre(StringBuilder e, Noeud racine, int level = 0)
        {
            if (racine == null) return; // Condition d'arrêt

            // Ajout des flèches et des informations du salarié dans le StringBuilder
            for (int i = 0; i < level - 1; i++)
            {
                e.Append("  │");
            }

            if (racine.Successeur == null && racine.Frere == null) e.Append("  └>");
            else if (level > 0) e.Append("  ├>");

            e.Append(racine.Salarie.Nom);
            e.Append(" (" + racine.Salarie.Poste + ")");
            e.AppendLine();

            // Appel récursif pour les successeurs et les frères
            SauvegarderArbre(e, racine.Successeur, level + 1); // Successeurs
            SauvegarderArbre(e, racine.Frere, level); // Frères (tous au même niveau)
        }

        private void Charger()
        {
            string path = "Entreprise.txt";
            String[] lines = File.ReadAllLines(path);
            int i = 0;

            while (i < lines.Length)
            {
                if (lines[i].StartsWith("Nom de l'entreprise")) // On enregistre le nom de l'entreprise
                {
                    nom = lines[i].Split(':')[1].Trim();
                }
                else if (lines[i].StartsWith("Clients"))
                {
                    i++;
                    while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i])) // On enregistre tous les clients
                    {
                        string[] DataC = lines[i].Split('-');
                        Client client = new Client(DataC[0].Trim(), DataC[1].Trim(), DataC[2].Trim(), DateTime.Parse(DataC[3].Trim()),"none@none","12 via none",DataC[4].Trim(), DataC[5].Trim());
                        clients.Add(client);
                        i++;
                    }
                }
                else if (lines[i].StartsWith("Commandes")) // On enregistre toutes les commandes
                {
                    i++;
                    while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]))
                    {
                        string[] DataCom = lines[i].Split('|');
                        Commande commande = new Commande(Clients.Find(c => c.Nom == DataCom[1].Trim()), DataCom[2].Substring(0, DataCom[2].IndexOf(" --> ")), DataCom[2].Substring(DataCom[2].IndexOf(" --> ")), Vehicules[0], this.Trouver(DataCom[3].Trim()), DateTime.Parse(DataCom[5].Trim()));
                        commandes.Add(commande);
                        i++;
                    }
                }
                else if (lines[i].StartsWith("Organigramme")) // On enregistre l'arbre N-aire
                {
                    i++;
                    root = LoadOrganigramme(lines,ref i, 0);
                }
                i++;
            }

             Noeud LoadOrganigramme(string[] lines, ref int i, int level)
            {
                Noeud noeud = new Noeud(new Salarie("00000", lines[i].Trim(), "TestSurname", DateTime.Parse("2020-01-01"), "Test", "Test", "Test", DateTime.Parse("2020-01-01"), "TestFunction", 2000));
                i++;

                Noeud LastEnfant = null;

                while (i < lines.Length && GetIndentation(lines[i]) > level)
                {
                    int cLevel = GetIndentation(lines[i]);
                    Noeud enfant = LoadOrganigramme(lines, ref i, cLevel);

                    if (LastEnfant == null) noeud.Successeur = enfant;
                    else LastEnfant.Frere = enfant;
                    LastEnfant = enfant;
                }
                return noeud;
            }

            int GetIndentation(string line)
            {
                int level = 0;
                while (line.StartsWith("  "))
                {
                    level++;
                    line = line.Substring(2);
                }
                return level;
            }
        }
    }
}     
