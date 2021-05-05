using System;
using System.Collections.Generic;//pour utiliser les listes


namespace Exercice_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            pseudo code:
            Si il est défini N nombre parfait à afficher
                Alors je commence les calculs pour rechercher les nombres parfaits
                je détermine les nombres parfaits et j'affiche les diviseurs

            Fin si 
                la liste des nombres parfaits est atteint  
            */

            int diviseur = 2;
            int reste;
            int entrerConvertie;
            bool entrerTester;
            string entrer;

            Console.WriteLine("Programme de recherche des nombres parfaits");
            Console.WriteLine("Entrer un nombre entier :");
            //Console.WriteLine("Combien de nombre parfaits souhaitez-vous afficher ? :");

            entrer = Console.ReadLine();

            entrerTester = int.TryParse(entrer,out entrerConvertie);

            if (entrerTester == false)
            {
                Console.WriteLine("Entrer un nombre entier s'il vous");
            }

            for (diviseur = 2; diviseur < entrerConvertie; diviseur++)
            {
                reste = (entrerConvertie % diviseur);
                Console.WriteLine("diviseur " + diviseur + " " + "reste " + reste);
                Console.WriteLine(reste);

                // Créer une liste 
                List<int> lesDiviseurs = new List<int> ();

                //Ajoute des éléments.
                //lesDiviseurs.Add(reste);

                // Affiche la capacité (taille de la liste)
                //Console.WriteLine(lesDiviseurs.Capacity);

                // Affiche le nombre d'éléments
                //Console.WriteLine(lesDiviseurs.Count);   
            }
            
            /*
            //Parcourir la liste avec la boucle for-each:
            foreach(string item in langage) {
            Console.WriteLine(item);
            */
            
            Console.ReadLine();
        }
    }
}
