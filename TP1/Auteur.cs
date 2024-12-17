using System;

class Auteur {
    public string ?nom { get; set; } 
    public string ?prenom { get; set; }

    public Auteur(string? nom, string? prenom) {
        this.nom = nom;
        this.prenom = prenom;
    }

    public void AfficherInformations(){
        Console.WriteLine($"{this.nom} {this.prenom}");
    }
  

}