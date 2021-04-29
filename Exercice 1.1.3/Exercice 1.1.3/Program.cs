using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieUsers;
            float total;
            string continuer;
            int toto = 0;

            Console.WriteLine("Programme de calcul de la moyenne de nombres.");

            do
            {
                Console.WriteLine("Veuillez saisir des nombres séparés par un espace :");

                saisieUsers = Console.ReadLine();
                string[] tableau = saisieUsers.Split(' ');
                
                    for (int i = 0; i < tableau.Length; i++)
                    {
                        toto += int.Parse(tableau[i]);
                    }

                    total = (float)toto / (float)tableau.Length;

                Console.WriteLine("La moyenne de " + saisieUsers + " est : " + total);
                Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");

                continuer = Console.ReadLine();
            }

            while(continuer.ToLower() == "o" );

            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadLine();
        }
    }
}


