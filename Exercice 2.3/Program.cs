using System;

namespace Exercice_2._3
{
    class Program
    {
        static void Main(string[] args)
        {   
            string a;
            string b;
            string continuer;
            int saissie;
            int saissieB;
            int aleatoire;

            //L'aafichage peut se faire sur une ligne ou 3
            Console.WriteLine("Jeu de la fourchette \nL'ordinateur « choisit » un nombre entier compris entre 0 et 100 \nEssayez de le deviner");
            /*
            Console.WriteLine("Jeu de la fourchette");
            Console.WriteLine("L'ordinateur « choisit » un nombre entier compris entre 0 et 100");
            Console.WriteLine("Essayez de le deviner");
            */

            a = Console.ReadLine();
            int.TryParse(a, out saissie);
            
            //Random est utilisé pour obtenir un nombre entier aléatoire.
            Random generationAleatoire = new Random();
            //Le nombre entier aléatoire est affecté à la variable "generationAleatoire"
            //Next(0,2) // (de X, a X) rang des chiffres généré
            aleatoire = generationAleatoire.Next(0,5);
            //Console.WriteLine(aleatoire);
            
                //Si le nombre généré est == au chiffre saissie
                if(aleatoire == saissie)
                {                    
                    //alors afficher "Vous avez trouver le chiffre"
                    //il y a deux façon d'écrire:
                    Console.WriteLine($"Vous avez trouver le chiffre : {aleatoire}");
                    //Console.Write("Vous avez trouver le chiffre : {0}",aleatoire);
                }
                else
                {
                    int fourchetteA = (aleatoire + 2);
                    int fourchetteB = (fourchetteA - 3);
                    Console.WriteLine($"La fourchette du chiffre à trouver se trouve entre : {fourchetteB} et {fourchetteA}");
                    Console.WriteLine("Souhaitez-vous faire un autre essai ? (O/N)");
                    continuer = Console.ReadLine();
                }

            do
            {
                b = Console.ReadLine();
                int.TryParse(b, out saissieB);
            }

            while(continuer.ToLower() == "o" );

            Console.WriteLine("Appuyez sur une touche  pour quitter");
            Console.ReadLine();
        }  
    }
}