using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevExo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie_a;
            int saisieConvertie_a;

            string saisie_b;
            int saisieConvertie_b;

            float total;
            bool saisie_a_Ok;
            bool saisie_b_Ok;

            Console.WriteLine("Programme de calcul de la moyenne de 2 nombres.");
            Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace :");

            string saisieUsers = Console.ReadLine();

            //Je crée un tableau de string "subs" qui contient la valeur de "saisieUsers" découpé à chaque fois qu'il y a un espace
            string[] subs = saisieUsers.Split(' ');

            saisie_a = subs[0];
            saisie_b = subs[1];
            saisie_a_Ok = int.TryParse(saisie_a, out saisieConvertie_a);
            saisie_b_Ok = int.TryParse(saisie_b, out saisieConvertie_b);

            if (saisie_a_Ok && saisie_b_Ok)
            {


                total = ((saisieConvertie_a + saisieConvertie_b) / 2);
                //Console.WriteLine(saisie_a + saisie_b);

                Console.WriteLine("La moyenne de " + saisie_a + " et " + saisie_b + " est de " + total);
            }
            else
            {
                Console.WriteLine("Erreur de saisie");
            }


            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadLine();
        }
    }
}
