using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    public class Commande
    {
        private static int TotalNumber = 1; // Nombre total de commandes créees
        private int id;
        private Client client;
        private string depart;
        private string arrivee;
        private double prix;
        private Vehicule vehicule;
        private Salarie chauffeur;
        private DateTime date;
        private Dictionary<string, Dictionary<string, double>> graphe = new Dictionary<string, Dictionary<string, double>>(); // On utilise un dictionnaire de dictionaire afin de représenter le graphe. Le premier string est le sommet, et le second dictionnaire contient toutes les arrêtes depuis ce sommet.

        // Constructeur :

        public Commande(Client client, string depart, string arrivee, Vehicule vehicule, Salarie chauffeur, DateTime date)
        {
            this.id = TotalNumber++;
            this.client = client;
            this.depart = depart;
            this.arrivee = arrivee;
            this.vehicule = vehicule;
            this.chauffeur = chauffeur;
            this.date = date;
            double prixParKm = 0;
            TotalNumber++;

            if (vehicule is Voiture) prixParKm = 0.30;
            else if (vehicule is Camionnette) prixParKm = 0.35;
            else if (vehicule is CamionBenne) prixParKm = 0.40; // On calcule le prix en fonction du type de véhicule
            else if (vehicule is CamionCiterne) prixParKm = 0.45;
            else if (vehicule is CamionFrigo) prixParKm = 0.50;

            double facteurAnciennete = 1+ (DateTime.Now.Year - chauffeur.Entree.Year)/100; // Tarif horaire du chauffeur en fonction de son ancienneté

            LoadGraph(); // Lecture du fichier csv afin de créer un graphe des routes disponibles
            double km = TrouveKm(depart, arrivee); // On cherche le plus court chemin avec l'algorithme de Dijkstra
            this.prix = Math.Round(km * prixParKm * facteurAnciennete); // On arrondi le prix à l'euro le plus proche
        }

        // Propriétes :

        public Client Client 
        { 
            get { return client; }
            set { this.client = value; }
        }
        public string Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        public string Arrivee
        {
            get { return arrivee; }
            set { arrivee = value; }
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public Vehicule Vehicule
        {
            get { return vehicule; }
            set { vehicule = value; }
        }
        public Salarie Chauffeur
        {
            get { return chauffeur; }
            set{ chauffeur = value;}
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value;}
        }
        public int Id
        {
            get { return id; }
        }

        // Fonctions :

        /// <summary>
        /// Crée un graphe des routes possibles avec leur poids à partir d'un fichier CSV.
        /// </summary>

        private void LoadGraph()
        {
            string path = "Distances.csv";
            string[] lines = File.ReadAllLines(path); // Lecture de toutes les lignes du fichier

            foreach (string line in lines)
            {
                string[] data = line.Split(';'); // Extraction des données de chaque ligne (Ville 1, Ville 2, distance)
                string city1 = data[0];
                string city2 = data[1]; 
                double distance = Convert.ToDouble(data[2]);

                if (graphe.ContainsKey(city1) == false) graphe[city1] = new Dictionary<string, double>(); // Ajout de chaque arrêtes au graphe
                if (graphe.ContainsKey(city2) == false) graphe[city2] = new Dictionary<string, double>();

                graphe[city1][city2] = distance;
                graphe[city2][city1] = distance; // On crée les arrêtes dans les deux sens, car chaques routes sont bi-directionelles
            }
        }

        /// <summary>
        /// Trouve le plus court chemin entre deux villes en utilisant l'algorithme de Dijkstra
        /// </summary>
        /// <param name="depart">Ville de départ</param>
        /// <param name="arrivee">Ville d'arrivée</param>
        /// <param name="print">Option d'affichage des étapes du trajet</param>

        public double TrouveKm(string depart, string arrivee, bool print = false)
        {
            if (!graphe.ContainsKey(depart) || !graphe.ContainsKey(arrivee))
            {
                Console.WriteLine("\nTrajet introuvable entre les deux villes !");
                Environment.Exit(0);
            }

            Dictionary<string, double> distances = new Dictionary<string,double>();
            Dictionary<string,string> prec = new Dictionary<string, string>();
            List<string> inconnus = new List<string>();

            foreach (string city in graphe.Keys)
            {
                distances[city] = 9999999;
                prec[city] = null;
                inconnus.Add(city);
            }

            distances[depart] = 0;
            while (inconnus.Count > 0) // On visite les noeuds adjacents
            {
                string currentCity = inconnus.OrderBy(c => distances[c]).First();
                inconnus.Remove(currentCity);

                if (currentCity == arrivee) break;

                foreach (var voisin in graphe[currentCity])
                {
                    double alt = distances[currentCity] + voisin.Value;
                    if (alt < distances[voisin.Key])
                    {
                        distances[voisin.Key] = alt;
                        prec[voisin.Key] = currentCity;
                    }
                }
            }

            // Reconstruction du chemin
            List<string> path = new List<string>();
            string current = arrivee;
            while (current != null)
            {
                path.Insert(0,current);
                current = prec[current];
            }

            if (path.Count < 2) return -1; // Si le chemin n'existe pas 

            if(print) Console.WriteLine("\n" + string.Join(" -> ", path) + " / " + distances[arrivee] + " kms\n"); // Affichage des étapes
            return distances[arrivee];
        }

        public override string ToString()
        {
            return id + " | " + client.Nom + " | " + depart +" -> " + arrivee + " | " + prix + " euros | " + chauffeur.Nom + " | " + date.ToShortDateString();
        }
    }
}
