using System;

namespace Exercice_2._3
{
    class Program
    {
        static void Main(string[] args)
        {   
            string a;
            int saissie;
            int aleatoire;
            int index;

            Console.WriteLine("Jeu de la fourchette \nL'ordinateur « choisit » un nombre entier compris entre 0 et 100");
            Console.WriteLine("Essayez de le deviner");

            a = Console.ReadLine();

            int.TryParse(a, out saissie);
            
            Random generationAleatoire = new Random();
            aleatoire = generationAleatoire.Next(0,2);
            Console.WriteLine(aleatoire);

            if(aleatoire == saissie)
            {                    
                Console.WriteLine(generationAleatoire);
                Console.WriteLine("Vous avez trouver le chiffre");
            }
            else
            {
                for(index = 0;index !=aleatoire ;index++)
                {
                    Console.WriteLine(generationAleatoire.Next(aleatoire,2));
                }
            }

            
            /*
            Random generationAleatoire = new Random();
            for (index = 1; index <= 5; index++)
            Console.WriteLine(generationAleatoire.Next(0,2));
            */

            






        }
    }
}
