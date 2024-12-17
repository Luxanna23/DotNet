using System;

class Livre {
    public string ?titre { get; set; }
    public Auteur ?Auteur { get; set; }
    public int ?annee;

    public Livre(string? titre, Auteur? Auteur, int? annee) {
        this.titre = titre;
        this.Auteur = Auteur;
        this.annee = annee;
    }

    public void AfficherInformations(){
        Console.WriteLine($"Titre : {this.titre}. Auteur : {this.Auteur}. Année : {this.annee}");
    }
}