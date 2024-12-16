// using System;

// class Livre { private string ?titre; private int nbPages;
// public string Titre{
//     get { return titre!; }
//     set { titre = value; }
// }

// public int NbPages
// {
//     get { return nbPages; }
//     set
//     {
//         if (value >= 1)
//         {
//             nbPages = value;
//         }
//         else
//         {
//             Console.WriteLine("Erreur : Le nombre de pages doit être supérieur ou égal à 1.");
//         }
//     }
// }

// public void AfficherInfos()
// {
//     Console.WriteLine($"Titre : {titre}");
//     Console.WriteLine($"Nombre de pages : {nbPages}");
// }

// }

// class Program { static void Main() { Livre monLivre = new Livre(); monLivre.Titre = "Titanic"; monLivre.NbPages = 1500;

//     monLivre.AfficherInfos();
// }
// }