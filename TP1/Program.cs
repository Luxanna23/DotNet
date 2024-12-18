using System;

class Program {
    public static ToutLesLivres toutLesLivres = new ToutLesLivres();
    static void Main() {
        Console.WriteLine("Bienvenue !");
        bool quitter = false;
        while (quitter == false) {

            Console.WriteLine("\n Que voulez vous faire ?\n 1. Ajouter un livre. \n 2. Afficher tous les livres. \n 3. Rechercher un livre par titre. \n 4. Supprimer un livre. \n 5. Quitter.");
            
            Console.Write("\n Choisissez une option : ");
            string number = Console.ReadLine()!;
            int option = Int32.Parse(number);

            switch (option) {
                case 1:
                    bool ajouter = true;
                    while (ajouter) {
                        AjouterLivre();
                        Console.Write("Voulez vous ajouter un autre livre? (o pour ajouter) : ");
                        string reponse = Console.ReadLine()!;
                        if (reponse == "o") {
                            ajouter = true;
                        }
                        else {
                            Console.Write("Votre reponse ne correspond pas.");
                            ajouter = false;
                        }
                    }
                    quitter = false;
                    break;
                case 2:
                    AfficherLivre();
                    quitter = false;
                    break;
                case 3:
                    ChercherLivre();
                    quitter = false;
                    break;
                case 4:
                    SupprimerLivre();
                    quitter = false;
                    break;
                case 5:
                    Console.WriteLine("Adieu");
                    quitter = true;
                    Environment.Exit(0);
                    break;
            }
        }
    }

    public static void AjouterLivre(){
        Console.Write("Rentrez le titre du livre : ");
        string titre = Console.ReadLine()!;

        Console.Write("Rentrez l'année du livre : ");
        string nb = Console.ReadLine()!;
        int annee = 0;
        try {
                annee = Int32.Parse(nb);
        }
        catch {
                Console.WriteLine("Erreur. La saisie n'est pas une année valide.");
        }

        Console.Write("Rentrez le Nom de l'auteur : ");
        string auteurNom = Console.ReadLine()!;

        Console.Write("Rentrez le Prenom de l'auteur : ");
        string auteurPrenom = Console.ReadLine()!;

        try {
            Auteur auteur = new Auteur(auteurNom, auteurPrenom);
            Livre livre = new Livre(titre, auteur, annee);
            toutLesLivres.AjouterDesLivre(livre);
            Console.WriteLine("Livre ajouté.");
        }
        catch {
            Console.WriteLine("Erreur lors de la création du livre.");
        }
        
    }

    public static void AfficherLivre(){
        toutLesLivres.getAllLivres();
    }

    public static void ChercherLivre() {
        Console.WriteLine("Entrez un titre de livre : ");
        string recherche = Console.ReadLine();
        toutLesLivres.ChercherTitre(recherche);
    }

    public static void SupprimerLivre(){
        Console.WriteLine("Entrez un titre de livre : ");
        string recherche = Console.ReadLine();
        toutLesLivres.SupprimerTitre(recherche);
    }
}