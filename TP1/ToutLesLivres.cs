using System;
using System.Collections.Generic;
using System.Linq;

class ToutLesLivres {
    public List<Livre> Livres { get; set; }

    public ToutLesLivres() {
        this.Livres = [];
    }

    public void AjouterDesLivre(Livre livre)
    {
        Livres.Add(livre);
    }

    public void getAllLivres()
    {
        for (int i = 0; i < Livres.Count; i++)
        {
            Livre livre = Livres[i];
            Console.WriteLine($"Livre {i + 1}:");
            Console.WriteLine($"Titre : {livre.titre}");
            Console.WriteLine($"Année : {livre.annee}");
            Console.WriteLine($"Auteur : {livre.Auteur}\n");
        }
    }

    public void ChercherTitre(string recherche){
        Livre livreTrouve = Livres.FirstOrDefault(livre => livre.titre.Equals(recherche, StringComparison.OrdinalIgnoreCase));
        if (livreTrouve != null)
        {
            Console.WriteLine($"Livre : {livreTrouve.titre}, Auteur: {livreTrouve.Auteur}");
        }
        else
        {
            Console.WriteLine("Aucun livre trouvé.");
        }
    }

    public void SupprimerTitre(string recherche){
        Livre livreTrouve = Livres.FirstOrDefault(livre => livre.titre.Equals(recherche, StringComparison.OrdinalIgnoreCase));
        if (livreTrouve != null)
        {
            Livres.Remove(livreTrouve);
            Console.WriteLine($"Livre supprimé.");
        }
        else
        {
            Console.WriteLine("Aucun livre trouvé.");
        }
    }
}