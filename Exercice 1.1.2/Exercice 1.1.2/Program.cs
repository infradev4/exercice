using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieUsers;

            /*string saisie_a;
            int saisieConvertie_a;

            string saisie_b;
            int saisieConvertie_b;
            */
            float total;
            /*
            bool saisie_a_Ok;
            bool saisie_b_Ok;
            */
            //string affResult = "La moyenne de ";
            string continuer;

            Console.WriteLine("Programme de calcul de la moyenne de 2 nombres.");
            Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace :");

            saisieUsers = Console.ReadLine();
            string[] subs = saisieUsers.Split(' ');

            /*saisie_a = subs[0];
            saisie_b = subs[1];
            saisie_a_Ok = int.TryParse(saisie_a, out saisieConvertie_a);
            saisie_b_Ok = int.TryParse(saisie_b, out saisieConvertie_b);
            */

            int toto = 0;

            for (int i = 0; i < subs.Length;i++)
            {
                //affResult += subs[i];
                toto += int.Parse(subs[i]);
            }
            
            total = toto/subs.Length;

            Console.WriteLine(total);

            /*
                    if ()
                    {
                        total = ((toto + subs.Length) / 2);

                        Console.WriteLine("La moyenne de " + toto + " et " + subs.Length + " est de " + total);
                    }
                    else
                    {
                        Console.WriteLine("Erreur de saisie");
                    }

            /*
                if (saisie_a_Ok && saisie_b_Ok)
                {
                    total = ((result + subs.Length) / 2);

                    Console.WriteLine("La moyenne de " + result + " et " + subs.Length + " est de " + total);
                }
                else
                {
                    Console.WriteLine("Erreur de saisie");
                }
            */
            Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");
            continuer = Console.ReadLine();

            if (continuer == "o")




            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadLine();
            

        }
    }
}


