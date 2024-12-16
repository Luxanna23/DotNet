// using System;
// class Exo7 {
//     static void Main()
//         {
//             int[] notes = new int[5]; 
//             int somme = 0;
//              for (int i = 0; i < notes.Length; i++)
//     {
//         Console.Write($"Entrez la note {i + 1} : ");
//         notes[i] = int.Parse(Console.ReadLine());
//         somme += notes[i];
//     }

//     Console.WriteLine("\nListe des notes saisies :");
//     foreach (int note in notes)
//     {
//         Console.WriteLine(note);
//     }

//     double moyenne = (double)somme / notes.Length;
//     Console.WriteLine($"\nLa moyenne des notes est : {moyenne:F2}");
// }
// }