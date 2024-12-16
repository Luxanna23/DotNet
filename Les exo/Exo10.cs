using System;
using System.Diagnostics;
class Exo10 {
    static void Main()
        {   
            Console.Write("Entrer un nombre : ");
            string number = Console.ReadLine()!;
            try {
                int nb = Int32.Parse(number);
                Console.WriteLine($"{nb} est bien un entier");
            }
            catch {
                Console.WriteLine("Erreur. La saisie n'est pas un nombre entier valide.");
            }
            finally
            {
                Console.WriteLine("Tentative de conversion terminée.");
            }
        }
}
