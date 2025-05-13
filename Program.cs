using ProjetA3___Lombard_Loubignac_Ledru;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ProjetA3___Lombard_Loubignac_Ledru
{
    internal class Program
    {

        // Main :

        static void Main(string[] args)
        {

            // Création des salariés :

            Salarie mrDupond = new Salarie("123456789", "Dupond", "Mr", new DateTime(1970, 1, 1), "1 rue de Paris", "dupond@mail.com", "0123456789", new DateTime(2010, 1, 1), "Directeur Général", 60000);
            Salarie mmeFiesta = new Salarie("123456790", "Fiesta", "Mme", new DateTime(1975, 5, 5), "2 rue de Paris", "fiesta@mail.com", "0234567890", new DateTime(2015, 5, 5), "Directrice Commerciale", 55000);
            Salarie mrForge = new Salarie("123456791", "Forge", "Mr", new DateTime(1980, 6, 6), "3 rue de Paris", "forge@mail.com", "0345678901", new DateTime(2018, 6, 6), "Commercial", 50000);
            Salarie mmeFermi = new Salarie("123456792", "Fermi", "Mme", new DateTime(1985, 7, 7), "4 rue de Paris", "fermi@mail.com", "0456789012", new DateTime(2019, 7, 7), "Commerciale", 48000);
            Salarie mrFetard = new Salarie("123456793", "Fetard", "Mr", new DateTime(1990, 8, 8), "5 rue de Paris", "fetard@mail.com", "0567890123", new DateTime(2020, 8, 8), "Directeur des opérations", 65000);
            Salarie mrRoyal = new Salarie("123456794", "Royal", "Mr", new DateTime(1995, 9, 9), "6 rue de Paris", "royal@mail.com", "0678901234", new DateTime(2021, 9, 9), "Chef Equipe", 55000);
            Salarie mrRomu = new Salarie("123456795", "Romu", "Mr", new DateTime(2000, 10, 10), "7 rue de Paris", "romu@mail.com", "0789012345", new DateTime(2022, 10, 10), "Chauffeur", 45000);
            Salarie mmeRomi = new Salarie("123456796", "Romi", "Mme", new DateTime(1980, 11, 11), "8 rue de Paris", "romi@mail.com", "0890123456", new DateTime(2023, 11, 11), "Chauffeur", 45000);
            Salarie mrRoma = new Salarie("123456797", "Roma", "Mr", new DateTime(1982, 12, 12), "9 rue de Paris", "roma@mail.com", "0901234567", new DateTime(2010, 12, 12), "Chauffeur", 45000);
            Salarie mmePrince = new Salarie("123456798", "Prince", "Mme", new DateTime(1973, 1, 1), "10 rue de Paris", "prince@mail.com", "0912345678", new DateTime(2012, 1, 1), "Chef Equipe", 55000);
            Salarie mmeRome = new Salarie("123456799", "Rome", "Mme", new DateTime(1974, 2, 2), "11 rue de Paris", "rome@mail.com", "0123456789", new DateTime(2012, 2, 2), "Chauffeur", 45000);
            Salarie mmeRimou = new Salarie("123456700", "Rimou", "Mme", new DateTime(1970, 3, 3), "12 rue de Paris", "rimou@mail.com", "1234567890", new DateTime(2017, 3, 3), "Chauffeur", 45000);
            Salarie mmeJoyeuse = new Salarie("123456701", "Joyeuse", "Mme", new DateTime(1990, 4, 4), "13 rue de Paris", "joyeuse@mail.com", "2345678901", new DateTime(2008, 4, 4), "Directrice des RH", 60000);
            Salarie mmeCouleur = new Salarie("123456702", "Couleur", "Mme", new DateTime(1979, 5, 5), "14 rue de Paris", "couleur@mail.com", "3456789012", new DateTime(2009, 5, 5), "Formation", 55000);
            Salarie mmeToutleMonde = new Salarie("123456703", "ToutleMonde", "Mme", new DateTime(1981, 6, 6), "15 rue de Paris", "toutlemonde@mail.com", "4567890123", new DateTime(2002, 6, 6), "Contrats", 50000);
            Salarie mrGripSous = new Salarie("123456704", "GripSous", "Mr", new DateTime(1962, 7, 7), "16 rue de Paris", "gripsous@mail.com", "5678901234", new DateTime(2003, 7, 7), "Directeur Financier", 65000);
            Salarie mrPicsou = new Salarie("123456705", "Picsou", "Mr", new DateTime(1965, 8, 8), "17 rue de Paris", "picsou@mail.com", "6789012345", new DateTime(2007, 8, 8), "Direction comptable", 60000);
            Salarie mmeFournier = new Salarie("123456706", "Fournier", "Mme", new DateTime(1994, 9, 9), "18 rue de Paris", "fournier@mail.com", "7890123456", new DateTime(2019, 9, 9), "Comptable", 55000);
            Salarie mmeGautier = new Salarie("123456707", "Gautier", "Mme", new DateTime(1995, 10, 10), "19 rue de Paris", "gautier@mail.com", "8901234567", new DateTime(2019, 10, 10), "Comptable", 55000);
            Salarie mrGrosSous = new Salarie("123456708", "GrosSous", "Mr", new DateTime(1980, 11, 11), "20 rue de Paris", "gros-sous@mail.com", "9012345678", new DateTime(2020, 2, 3), "Controleur de gestion", 55000);

            List<Salarie> listeSalaries = new List<Salarie> { mrDupond, mmeFiesta, mrForge, mmeFermi, mrFetard, mrRoyal, mrRomu, mmeRomi, mrRoma, mmePrince, mmeRome, mmeRimou, mmeJoyeuse, mmeCouleur, mmeToutleMonde, mrGripSous, mrPicsou, mmeFournier, mmeGautier, mrGrosSous };


            // Création des clients :

            Client client1 = new Client("223456789", "Durand", "Jean", new DateTime(1980, 1, 1), "21 rue de Paris", "durand@mail.com", "0123456789","Paris");
            Client client2 = new Client("223456790", "Martin", "Marie", new DateTime(1985, 2, 2), "22 rue de Paris", "martin@mail.com", "0234567890","Lyon");
            Client client3 = new Client("223456791", "Dubois", "Luc", new DateTime(1990, 3, 3), "23 rue de Paris", "dubois@mail.com", "0345678901","Marseille");
            Client client4 = new Client("223456792", "Bernard", "Sophie", new DateTime(1995, 4, 4), "24 rue de Paris", "bernard@mail.com", "0456789012","Paris");
            Client client5 = new Client("223456793", "Petit", "Paul", new DateTime(2000, 5, 5), "25 rue de Paris", "petit@mail.com", "0567890123","Monaco");
            Client client6 = new Client("223456794", "Leroux", "Isabelle", new DateTime(2005, 6, 6), "26 rue de Paris", "leroux@mail.com", "0678901234","Angers");
            Client client7 = new Client("223456795", "Moreau", "Pierre", new DateTime(2010, 7, 7), "27 rue de Paris", "moreau@mail.com", "0789012345","Toulon");
            Client client8 = new Client("223456796", "Simon", "Céline", new DateTime(2015, 8, 8), "28 rue de Paris", "simon@mail.com", "0890123456","Pau");
            Client client9 = new Client("223456797", "Lefebvre", "François", new DateTime(2020, 9, 9), "29 rue de Paris", "lefebvre@mail.com", "0901234567", "La Rochelle");
            Client client10 = new Client("223456798", "Girard", "Sylvie", new DateTime(2025, 10, 10), "30 rue de Paris", "girard@mail.com", "0912345678","Nimes");

            List<Client> listeClients = new List<Client> { client1, client2, client3, client4, client5, client6, client7, client8, client9, client10 };

            // Création des véhicules : 

            Voiture voiture1 = new Voiture(5);
            Voiture voiture2 = new Voiture(7);
            Camionnette camionnette1 = new Camionnette("Matériel chantier");
            Camionnette camionnette2 = new Camionnette("Verrerie");
            CamionCiterne camionciterne1 = new CamionCiterne(new List<string>() { "Eau", "Ciment" }, 10000, "Cuve longue");
            CamionBenne camionbenne1 = new CamionBenne(new List<string>() { "gravier", "sable" }, 10000, 2,true);
            CamionFrigo camionfrigo1 = new CamionFrigo(new List<string>() { "Viande", "sandwichs", "glaces" }, 10000, 3);

            List<Vehicule> listevéhicules= new List<Vehicule>() { voiture1, voiture2, camionnette1,camionnette2, camionciterne1, camionbenne1, camionfrigo1 };

            // Création des commandes : 

            Commande c1 = new Commande(client1, "Paris", "La Rochelle", voiture2, mrRoma, DateTime.Parse("2024-01-01"));
            Commande c2 = new Commande(client4, "La Rochelle", "Paris", camionbenne1, mrRoma, DateTime.Parse("2024-01-02"));
            Commande c3 = new Commande(client3, "Paris", "Lyon", camionfrigo1, mrRomu, DateTime.Parse("2024-07-07"));
            Commande c4 = new Commande(client7, "Paris", "Angers", voiture1, mrRomu, DateTime.Parse("2024-09-09"));

            List<Commande> listecommandes = new List<Commande>() { c1, c2, c3, c4};


            // Création de l'entreprise :

            Entreprise entreprise = new Entreprise("TransConnect",listeClients,listevéhicules,listecommandes);

            entreprise.Ajouter(null, mrDupond); // Ajout du directeur général

            entreprise.Ajouter(mrDupond,mmeFiesta); //Ajout des 4 directeurs sous le DG
            entreprise.Ajouter(mrDupond, mrFetard);
            entreprise.Ajouter(mrDupond, mmeJoyeuse);
            entreprise.Ajouter(mrDupond, mrGripSous);

            entreprise.Ajouter(mmeFiesta, mrForge); // Ajout du service Commercial
            entreprise.Ajouter(mmeFiesta, mmeFermi);

            entreprise.Ajouter(mrFetard, mrRoyal); // Ajout des chefs d'équipes
            entreprise.Ajouter(mrFetard, mmePrince);

            entreprise.Ajouter(mrRoyal, mrRomu); // Ajout des conducteurs
            entreprise.Ajouter(mrRoyal, mmeRomi);
            entreprise.Ajouter(mrRoyal, mrRoma);
            entreprise.Ajouter(mmePrince, mmeRome);
            entreprise.Ajouter(mmePrince, mmeRimou);

            entreprise.Ajouter(mmeJoyeuse, mmeCouleur); // Ajout des RH
            entreprise.Ajouter(mmeJoyeuse, mmeToutleMonde);

            entreprise.Ajouter(mrGripSous, mrPicsou); // Ajout du service financier
            entreprise.Ajouter(mrGripSous, mrGrosSous);
            entreprise.Ajouter(mrPicsou, mmeFournier);
            entreprise.Ajouter(mrPicsou, mmeGautier);

            // Menu : 

            string logo = "\r\n████████╗██████╗░░█████╗░███╗░░██╗░██████╗░█████╗░░█████╗░███╗░░██╗███╗░░██╗███████╗░█████╗░████████╗\r\n╚══██╔══╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔══██╗████╗░██║████╗░██║██╔════╝██╔══██╗╚══██╔══╝\r\n░░░██║░░░██████╔╝███████║██╔██╗██║╚█████╗░██║░░╚═╝██║░░██║██╔██╗██║██╔██╗██║█████╗░░██║░░╚═╝░░░██║░░░\r\n░░░██║░░░██╔══██╗██╔══██║██║╚████║░╚═══██╗██║░░██╗██║░░██║██║╚████║██║╚████║██╔══╝░░██║░░██╗░░░██║░░░\r\n░░░██║░░░██║░░██║██║░░██║██║░╚███║██████╔╝╚█████╔╝╚█████╔╝██║░╚███║██║░╚███║███████╗╚█████╔╝░░░██║░░░\r\n░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚════╝░╚═╝░░╚══╝╚═╝░░╚══╝╚══════╝░╚════╝░░░░╚═╝░░░\n\n";
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(logo);
                Console.WriteLine("Que voulez-vous faire ? \n");
                Console.WriteLine("1 - Gérer les clients\n2 - Gérer les employés\n3 - Gérer les commandes\n4 - Statistiques\n5 - Autre\n6 - Fermer l'application\n");
                int res = Convert.ToInt32(Console.ReadLine());

                switch (res)
                {
                    case 1:
                        bool exitM1 = false;
                        while (!exitM1)
                        {
                            Console.Clear();
                            Console.WriteLine(logo);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  Gestion des clients \n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1 - Ajouter un nouveau client\n2 - Supprimer un client\n3 - Modifier un client\n4 - Afficher les clients\n5 - Retour\n");
                            int resC = Convert.ToInt32(Console.ReadLine());
                            switch (resC)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Entrez les informations du nouveau client :\n");

                                    Console.WriteLine("Entrez son numéro de sécurité sociale : ");
                                    string idc = Console.ReadLine();

                                    Console.WriteLine("Entrez son nom de famille : ");
                                    string lastNamec = Console.ReadLine();

                                    Console.WriteLine("Entrez son prénom: ");
                                    string firstNamec = Console.ReadLine();

                                    Console.WriteLine("Entrez sa date de naissance (AAAA-MM-JJ) : ");
                                    DateTime dateOfBirthc;
                                    while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirthc))
                                    {
                                        Console.WriteLine("\nFormat invalide !");
                                        Console.WriteLine("Entrez sa date de naissance (AAAA-MM-JJ) : ");
                                    }

                                    Console.WriteLine("Entrez sa ville de résidence : ");
                                    string cityc = Console.ReadLine();

                                    Console.WriteLine("Entrez son adresse : ");
                                    string addressc = Console.ReadLine();

                                    Console.WriteLine("Entrez son email : ");
                                    string emailc = Console.ReadLine();

                                    Console.WriteLine("Entrez son numéro de téléphone : ");
                                    string phoneNumberc = Console.ReadLine();

                                    Client client = new Client(idc, lastNamec, firstNamec, dateOfBirthc, addressc, emailc, phoneNumberc,cityc);

                                    entreprise.Clients.Add(client);
                                    Console.WriteLine("\nClient ajouté !");
                                    Thread.Sleep(1000);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Entrez le nom du client que vous souhaitez supprimer :\n");
                                    string clientremove = Console.ReadLine();
                                    Client toremove = entreprise.Clients.Find(client => client.Nom.ToUpper() == clientremove.ToUpper()); // Delegation lambda méthode
                                    if(toremove != null)
                                    {
                                        entreprise.Clients.Remove(toremove);
                                        Console.WriteLine("\nClient supprimé !");
                                    }
                                    else Console.WriteLine("Impossible de trouver ce client...");
                                    Thread.Sleep(1000);
                                    break;

                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Entrez le nom du client que vous souhaitez modifier :\n");
                                    string clientedit = Console.ReadLine();
                                    Client toedit = entreprise.Clients.Find(client => client.Nom.ToUpper() == clientedit.ToUpper()); // Delegation lambda méthode
                                    if (toedit != null)
                                    {
                                        Console.WriteLine("Entrez les nouvelles informations du client :\n");

                                        Console.WriteLine("Entrez son numéro de sécurité sociale : ");
                                        string ide = Console.ReadLine();

                                        Console.WriteLine("Entrez son nom de famille : ");
                                        string lastNamee = Console.ReadLine();

                                        Console.WriteLine("Entrez son prénom : ");
                                        string firstNamee = Console.ReadLine();

                                        Console.WriteLine("Entrez sa date de naissance (AAAA-MM-JJ) : ");
                                        DateTime dateOfBirthe;
                                        while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirthe))
                                        {
                                            Console.WriteLine("\nFormat invalide !");
                                            Console.WriteLine("Entrez sa date de naissance (AAAA-MM-JJ) : ");
                                        }

                                        Console.WriteLine("Entrez sa ville de résidence : ");
                                        string citye = Console.ReadLine();

                                        Console.WriteLine("Entrez son adresse : ");
                                        string addresse = Console.ReadLine();

                                        Console.WriteLine("Entrez son email : ");
                                        string emaile = Console.ReadLine();

                                        Console.WriteLine("Entrez son numéro de téléphone : ");
                                        string phoneNumbere = Console.ReadLine();


                                        toedit.Edit(ide,lastNamee, firstNamee,dateOfBirthe,addresse,emaile,phoneNumbere,citye);
                                        Console.WriteLine("\nClient modifié !");
                                    }
                                    else Console.WriteLine("Impossible de trouver le client...");
                                    Thread.Sleep(1000);
                                    break;
                                
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Clients triés par nom :\n");
                                    entreprise.Clients.Sort(); // On utilise le .Sort grâce à notre implémentation de IComparable
                                    entreprise.AfficherClients();
                                    Console.WriteLine("\nClients triés par ville :\n");
                                    entreprise.Clients.Sort((x, y) => x.Ville.CompareTo(y.Ville)); // On trie les clients en définissant un sort sur les villes
                                    entreprise.AfficherClients();
                                    Console.WriteLine("\nClients triés par total d'achats :\n");
                                    entreprise.Clients.Sort((x, y) => entreprise.TotalAchat(y).CompareTo(entreprise.TotalAchat(x))); // On trie les clients en définissant un sort sur le total d'achat grâce à notre fonction TotalAchat(...)
                                    entreprise.AfficherClientsTotal();
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;

                                default:
                                    exitM1 = true;
                                    break;
                            }
                        }
                            break;
                    case 2:
                        bool exitM2 = false;
                        while (!exitM2)
                        {
                            Console.Clear();
                            Console.WriteLine(logo);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  Gestion des employés \n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1 - Afficher le diagramme d'entreprise\n2 - Recruter un employé\n3 - Licencier un employé\n4 - Retour\n");
                            int resS = Convert.ToInt32(Console.ReadLine());
                            switch (resS)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Voici le diagramme de l'entreprise :\n");
                                    entreprise.Afficher(entreprise.Salaries); // On afiiche l'arbre n-aire
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Entrez les informations du nouvel employé :\n");

                                    Console.WriteLine("Entrez son numéro de sécurité sociale : ");
                                    string id = Console.ReadLine();

                                    Console.WriteLine("Entrez son nom de famille : ");
                                    string lastName = Console.ReadLine();

                                    Console.WriteLine("Entrez son prénom : ");
                                    string firstName = Console.ReadLine();

                                    Console.WriteLine("Entrez sa date de naissance (AAAA-MM-JJ) : ");
                                    DateTime dateOfBirth;
                                    while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
                                    {
                                        Console.WriteLine("\nFormat invalide !");
                                        Console.WriteLine("Entrez sa date de naissance (AAAA-MM-JJ) : ");
                                    }

                                    Console.WriteLine("Entrez son adresse : ");
                                    string address = Console.ReadLine();

                                    Console.WriteLine("Entrez son email : ");
                                    string email = Console.ReadLine();

                                    Console.WriteLine("Entrez son numéro de téléphone : ");
                                    string phoneNumber = Console.ReadLine();

                                    Console.WriteLine("Entrez sa date de début de contrat (AAAA-MM-JJ) : ");
                                    DateTime startDate;
                                    while (!DateTime.TryParse(Console.ReadLine(), out startDate))
                                    {
                                        Console.WriteLine("\nFormat invalide !");
                                        Console.WriteLine("Entrez sa date de début de contrat (AAAA-MM-JJ) : ");
                                    }

                                    Console.WriteLine("Entrez son poste : ");
                                    string position = Console.ReadLine();

                                    Console.WriteLine("Enter son salaire : ");
                                    double salary = Convert.ToDouble(Console.ReadLine());

                                    Salarie salarie = new Salarie(id, lastName, firstName, dateOfBirth, address, email, phoneNumber, startDate, position, salary);

                                    Console.WriteLine("\nEntrez le nom de son supérieur :\n");
                                    string superiorName = Console.ReadLine();
                                    Salarie superior = entreprise.Trouver(superiorName);
                                    if (superior != null)
                                    {
                                        entreprise.Ajouter(superior, salarie);
                                        Console.WriteLine("Employé ajouté !");
                                    }
                                    else Console.WriteLine("\nImpossible de trouver le supérieur...");
                                    Thread.Sleep(1000);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("\nEntrez le nom de l'employé que vous voulez licencier : \n");
                                    string fireName = Console.ReadLine();
                                    Salarie firesalarie = entreprise.Trouver(fireName);
                                    if (firesalarie != null)
                                    {
                                        entreprise.Supprimer(entreprise.TrouverN(firesalarie));
                                        Console.WriteLine("Employé licencié !");
                                    }
                                    else Console.WriteLine("\nImpossible de trouver l'employé...");
                                    Thread.Sleep(1000);
                                    break;
                                default:
                                    exitM2 = true;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        bool exitM3 = false;
                        while (!exitM3)
                        {
                            Console.Clear();
                            Console.WriteLine(logo);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  Gestion des commandes \n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1 - Créer une commande\n2 - Modifier une commande\n3 - Afficher les commandes\n4 - Retour\n");
                            int resO = Convert.ToInt32(Console.ReadLine());
                            switch (resO)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Entrez les informations de la commande :\n");

                                    Console.WriteLine("Entrez le nom du client : \n");
                                    string Cname = Console.ReadLine();
                                    Client OrderClient = entreprise.Clients.Find( c => c.Nom.ToUpper() == Cname.ToUpper());
                                    if (OrderClient == null)
                                    {
                                        Console.WriteLine("\nImpossible de trouver le client...");
                                        Thread.Sleep(1000);
                                        break;
                                    }

                                    Console.WriteLine("\nEntrez la date de livraison (AAAA-MM-JJ) : \n");
                                    DateTime deliveryDate;
                                    while (!DateTime.TryParse(Console.ReadLine(), out deliveryDate))
                                    {
                                        Console.WriteLine("\nFormat invalide !");
                                        Console.WriteLine("Entrez la date de livraison (AAAA-MM-JJ) : \n");
                                    }

                                    Console.WriteLine("\nQuel véhicule voulez-vous utiliser ? (1-7)\n");
                                    int z = 1;
                                    foreach(Vehicule v in entreprise.Vehicules)
                                    {
                                        Console.WriteLine(z + " - " + v.ToString());
                                        z++;
                                    }
                                    int numberVe = Convert.ToInt32(Console.ReadLine());
                                    foreach(Commande com in entreprise.Commandes) // On vérifie si le véhicule est déja utilisé ou non ce jour là
                                    {
                                        if(com.Date == deliveryDate && com.Vehicule == entreprise.Vehicules[numberVe - 1])
                                        {
                                            Console.WriteLine("Ce véhicule est déja utilisé ce jour !");
                                            Thread.Sleep(1000);
                                            return;
                                        }
                                    }

                                    Console.WriteLine("\nEntrez le nom du chauffeur : \n");
                                    string Dname = Console.ReadLine();
                                    Salarie Driver = entreprise.Trouver(Dname);
                                    if (Driver == null)
                                    {
                                        Console.WriteLine("\nImpossible de trouver le chauffeur...");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    else if (Driver.Poste != "Chauffeur")
                                    {
                                        Console.WriteLine("\ncet employé n'est pas un chauffeur !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    foreach (Commande com in entreprise.Commandes) // On vérifie si le chauffeur est disponible
                                    {
                                        if (com.Date == deliveryDate && com.Chauffeur == Driver)
                                        {
                                            Console.WriteLine("Ce chauffeur n'est pas libre ce jour-ci!");
                                            Thread.Sleep(1000);
                                            return;
                                        }
                                    }

                                    Console.WriteLine("\nEntrez la ville de départ : \n");
                                    string start = Console.ReadLine();

                                    Console.WriteLine("\nEntrez la ville d'arrivée : \n");
                                    string arrival = Console.ReadLine();

                                    Commande c = new Commande(OrderClient, start, arrival, entreprise.Vehicules[numberVe-1],Driver,deliveryDate);
                                    double test = c.TrouveKm(start, arrival,true);
                                    if(test == -1)
                                    {
                                        Console.WriteLine("\nImpossible de trouver une route entre " + start +" et " + arrival + " !");
                                        Thread.Sleep(1000);
                                        break;
                                    }

                                    entreprise.Commandes.Add(c);
                                    Console.WriteLine("\nCommande réussie !");
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    Thread.Sleep(3000);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Quel est le numéro de la commande que vous voulez modifier ?\n");
                                    int Dnverif = Convert.ToInt32(Console.ReadLine());

                                    Commande Tomodif = entreprise.ChercherCommande(Dnverif);
                                    if (Tomodif == null)
                                    {
                                        Console.WriteLine("\nImpossible de trouver la commande...");
                                        Thread.Sleep(1000);
                                        break;
                                    }

                                    Console.WriteLine("\nCette commande à été trouvée : \n");
                                    Console.WriteLine(Tomodif);

                                    Console.WriteLine("\nVoulez-vous la modifier ? (oui/non)\n");
                                    string modify = Console.ReadLine();
                                    if(modify != "oui")
                                    {
                                        Console.WriteLine("\nRetour sans modification");
                                        Thread.Sleep(1000);
                                        break;
                                    }

                                    Console.WriteLine("\nEntrez les nouvelles informations de cette commande :\n");

                                    Console.WriteLine("Entrez le nom du client : \n");
                                    string Cname2 = Console.ReadLine();
                                    Client OrderClient2 = entreprise.Clients.Find(c => c.Nom.ToLower() == Cname2.ToLower());
                                    if (OrderClient2 == null)
                                    {
                                        Console.WriteLine("\nImpossible de trouver le client...");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    Tomodif.Client = OrderClient2;

                                    Console.WriteLine("\nEntrez la date de livraison (AAAA-MM-JJ) : \n");
                                    DateTime deliveryDate2;
                                    while (!DateTime.TryParse(Console.ReadLine(), out deliveryDate2))
                                    {
                                        Console.WriteLine("\nFormat invalide !");
                                        Console.WriteLine("Entrez la date de livraison (AAAA-MM-JJ) : \n");
                                    }
                                    Tomodif.Date = deliveryDate2;


                                    Console.WriteLine("\nQuel véhicule voulez-vous utiliser ? (1-7)\n");
                                    int z2 = 1;
                                    foreach (Vehicule v in entreprise.Vehicules)
                                    {
                                        Console.WriteLine(z2 + " - " + v.ToString());
                                        z2++;
                                    }
                                    int numberVe2 = Convert.ToInt32(Console.ReadLine());
                                    foreach (Commande com in entreprise.Commandes) // On vérifie si le véhicule est déja utilisé ou non ce jour là
                                    {
                                        if (com.Date == deliveryDate2 && com.Vehicule == entreprise.Vehicules[numberVe2 - 1])
                                        {
                                            Console.WriteLine("Ce véhicule est déja utilisé ce jour !");
                                            Thread.Sleep(1000);
                                            return;
                                        }
                                    }
                                    Tomodif.Vehicule = listevéhicules[numberVe2-1];

                                    Console.WriteLine("\nEntrez le nom du chauffeur : \n");
                                    string Dname2 = Console.ReadLine();
                                    Salarie Driver2 = entreprise.Trouver(Dname2);
                                    if (Driver2 == null)
                                    {
                                        Console.WriteLine("\nImpossible de trouver ce chauffeur...");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    else if (Driver2.Poste != "Chauffeur")
                                    {
                                        Console.WriteLine("\nCet employé n'est pas un chauffeur !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    foreach (Commande com in entreprise.Commandes) // On vérifie si le chauffeur est disponible
                                    {
                                        if (com.Date == deliveryDate2 && com.Chauffeur == Driver2)
                                        {
                                            Console.WriteLine("Ce chauffeur n'est pas libre ce jour-ci!");
                                            Thread.Sleep(1000);
                                            return;
                                        }
                                    }
                                    Tomodif.Chauffeur = Driver2;

                                    Console.WriteLine("\nEntrez la ville de départ : \n");
                                    Tomodif.Depart = Console.ReadLine();

                                    Console.WriteLine("\nEntrez la ville d'arrivée : \n");
                                    Tomodif.Arrivee = Console.ReadLine();

                                    double test2 = Tomodif.TrouveKm(Tomodif.Depart, Tomodif.Arrivee, true);
                                    if (test2 == -1)
                                    {
                                        Console.WriteLine("\nImpossible de trouver une route entre " + Tomodif.Depart + " et " + Tomodif.Arrivee + " !");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                    Console.WriteLine("\nCommande réussie !");
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    Thread.Sleep(3000);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.WriteLine("Liste de toutes les commandes :\n");
                                    foreach (Commande com in entreprise.Commandes)
                                    {
                                        Console.WriteLine(com);
                                    }
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                default:
                                    exitM3 = true;
                                    break;
                            }
                        }
                        break;
                    case 4:
                        bool exitM4 = false;
                        while (!exitM4)
                        {
                            Console.Clear();
                            Console.WriteLine(logo);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Statistiques \n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1 - nombre de livraisons par chauffeur\n2 - Commandes entre deux dates\n3 - Moyenne des prix des commandes\n4 - Moyenne des comptes clients\n5 - Liste des commandes d'un client\n6 - Retour\n");
                            int resSt = Convert.ToInt32(Console.ReadLine());
                            switch (resSt)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  nombre de livraisons par chauffeur\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    List<Salarie> chauffeurs = new List<Salarie> { };
                                    foreach (Commande c in entreprise.Commandes)
                                    {
                                        int compteur = 0;
                                        bool verif = false; 

                                        foreach (Salarie chauffeur in chauffeurs)
                                        {
                                            if (c.Chauffeur == chauffeur) { verif = true; break; }
                                        }
                                        if (!verif)
                                        {
                                            foreach (Commande cc in entreprise.Commandes)
                                            {
                                                if (cc.Chauffeur == c.Chauffeur) compteur++;
                                            }
                                            chauffeurs.Add(c.Chauffeur);
                                            Console.Write("\n" + c.Chauffeur.Nom + " : " + compteur + " livraisons");
                                        }
                                    }
                                    Console.WriteLine("\n\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Commandes entre deux dates\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Entrez la date de départ (AAAA-MM-JJ) : ");
                                    DateTime D1;
                                    while (!DateTime.TryParse(Console.ReadLine(), out D1))
                                    {
                                        Console.WriteLine("Date Invalide !");
                                        Console.WriteLine("Entrez la date de départ (AAAA-MM-JJ) : ");
                                    }
                                    Console.WriteLine("Entrez la date de fin (AAAA-MM-JJ) : ");
                                    DateTime D2;
                                    while (!DateTime.TryParse(Console.ReadLine(), out D2))
                                    {
                                        Console.WriteLine("Date Invalide !");
                                        Console.WriteLine("Entrez la date de fin (AAAA-MM-JJ) : ");
                                    }

                                    foreach (Commande c in entreprise.Commandes)
                                    {
                                        if (c.Date > D1 && c.Date < D2) Console.WriteLine(c);
                                    }

                                    Console.WriteLine("\n\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Moyenne des prix des commandes\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    double moyenne = 0;
                                    foreach (Commande c in entreprise.Commandes)
                                    {
                                        moyenne += c.Prix;
                                    }
                                    moyenne = moyenne / entreprise.Commandes.Count();
                                    Console.WriteLine("\nPrix moyen des commandes : " + moyenne);
                                    Console.WriteLine("\n\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Moyenne des comptes clients\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    List<Client> MoyenneClients = new List<Client> { };
                                    foreach (Commande c in entreprise.Commandes)
                                    {
                                        double moyenneC = 0;
                                        bool verif = false;
                                        int cpt = 0;

                                        foreach (Client cli in MoyenneClients)
                                        {
                                            if (c.Client == cli) { verif = true; break; }
                                        }
                                        if (!verif)
                                        {
                                            foreach (Commande cc in entreprise.Commandes)
                                            {
                                                if (cc.Client == c.Client)
                                                {
                                                    moyenneC += c.Prix;
                                                    cpt++;
                                                }
                                            }
                                            MoyenneClients.Add(c.Client);
                                            moyenneC /= cpt;
                                            Console.Write("\nMoyenne d'achats de " + c.Client.Nom + " : " + moyenneC);
                                        }
                                    }
                                    Console.WriteLine("\n\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Liste des commandes d'un client\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Entrez le nom du client :\n");
                                    string clientListe = Console.ReadLine();
                                    Client CListe = entreprise.Clients.Find(client => client.Nom.ToLower() == clientListe.ToLower());
                                    if (CListe != null)
                                    {
                                        Console.Clear();
                                        Console.WriteLine(logo);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("  Liste des commandes de " + clientListe + "\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        foreach(Commande c in entreprise.Commandes)
                                        {
                                            if (c.Client == CListe) Console.WriteLine(c);
                                        }
                                    }
                                    else Console.WriteLine("\nImpossible de trouver le client...");
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;

                                default:
                                    exitM4 = true;
                                    break;
                            }
                        }
                        break;

                    case 5:
                        bool exitM5 = false;
                        while (!exitM5)
                        {
                            Console.Clear();
                            Console.WriteLine(logo);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Autre \n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("1 - Sauvegarder l'entreprise\n2 - Vérifier la force de votre mot de passe\n3 - Quizz sur l'entreprise\n4 - Suggestions d'améliorations\n5 - Retour\n");
                            int resA = Convert.ToInt32(Console.ReadLine());
                            switch (resA)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Sauvegarde de l'entreprise\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nSauvegarde en cours : \n");
                                    for (int i =0;i<35;i++)
                                    {
                                        Console.Write("#");
                                        Thread.Sleep(100);
                                    }
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Sauvegarde de l'entreprise\n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    entreprise.Sauvegarder();

                                    Console.WriteLine("\nSauvegarde réussie ! \nFichier exporté sous Entreprise.txt");
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Vérification de la force du mot de passe\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nEntrez votre mot de passe :\n");
                                    string password = Console.ReadLine();
                                    CheckPassword(password);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Quizz sur l'entreprise\n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.WriteLine("\nVoici un petit quizz sur notre entreprise... Serez-vous à la hauteur ?");
                                    int score = 0;

                                    Console.WriteLine("\nQuestion 1 : Quel est le nom de notre entreprise ?\n");
                                    string reponse1 = Console.ReadLine();
                                    if (reponse1.ToUpper() == entreprise.Nom.ToUpper())
                                    {
                                        Console.WriteLine("Correct !");
                                        score++;
                                    }
                                    else Console.WriteLine("Incorrect... La réponse était : " + entreprise.Nom);

                                    Console.WriteLine("\nQuestion 2 : Combien de clients avons-nous ?\n");
                                    int reponse2 = Convert.ToInt32(Console.ReadLine());
                                    if (reponse2 == entreprise.Clients.Count())
                                    {
                                        Console.WriteLine("Correct !");
                                        score++;
                                    }
                                    else Console.WriteLine("Incorrect... La réponse était : " + entreprise.Clients.Count);

                                    Console.WriteLine("\nQuestion 3 : Quel est le poste de M. Dupond ?\n");
                                    string reponse3 = Console.ReadLine();
                                    if (reponse3.ToLower() == "directeur general")
                                    {
                                        Console.WriteLine("Correct !");
                                        score++;
                                    }
                                    else Console.WriteLine("Incorrect... La réponse était : directeur general");

                                    Console.WriteLine("\nVotre score final est de : " + score + " / 3 !");
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Suggestions d'améliorations\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nQuelles sont vos suggestions afin d'améliorer notre application ?\n");
                                    string suggestions = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine(logo);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("  Suggestions d'améliorations\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\nMerci pour votre retour ! Nous allons tout faire pour satisfaire vos suggestions suivantes :\n");
                                    Console.WriteLine(suggestions);
                                    Console.WriteLine("\nAppuyez sur une touche pour continuer");
                                    Console.ReadKey();
                                    break;

                                default:
                                    exitM5 = true;
                                    break;
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(logo);
                        Console.WriteLine("Au revoir !");
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

        }

        /// <summary>
        /// Vérification de la force d'un mot de passe
        /// </summary>
        /// <param name="password">Mot de passe à vérifier</param>

        public static void CheckPassword(string password)
        {
            if (password.Length < 8) // On vérifie si le mot de passe est assez long
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFaible - Le mot de passe est trop court...");
                return;
            }

            // On vérifie la complexité du mot de passe en utilisant des REGEX :
            bool maj = Regex.IsMatch(password, "[A-Z]");
            bool min = Regex.IsMatch(password, "[a-z]");
            bool number = Regex.IsMatch(password, "[0-9]");
            bool special = Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            int complexite = 0;
            if (maj == true) complexite++;
            if (min == true) complexite++;
            if (number== true) complexite++;
            if (special == true) complexite++;

            if (complexite < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nFaible - Le mot de passe n'est pas assez complexe...");
            }
            else if (complexite == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nMoyen - Le mot de passe peut être amélioré");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nFort - Le mot de passe est sécurisé !");
            }
        }
    }
}