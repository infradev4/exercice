using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisieUsers;

            string saisie_a;
            string saisie_b;

            int saisieConvertie_a;

            bool saisie_a_Ok;

            float total;
            float conversion_mi = 1.60F;
           
            Console.WriteLine("Programme de conversion Kilomètres <-> Miles.");
            Console.WriteLine("Saisir une valeur et son unité de mesure (séparés par un espace) :");

            saisieUsers = Console.ReadLine();

            string[] subs = saisieUsers.Split(' ');

            saisie_a = subs[0];
            saisie_b = subs[1];

            saisie_a_Ok = int.TryParse(saisie_a, out saisieConvertie_a);

            if (saisie_a_Ok)
            {

                Console.WriteLine();

                if (saisie_b != "mi")
                {
                    total = (saisieConvertie_a / conversion_mi);
                    Console.WriteLine(saisie_a + " Kilomètres = " + total + " Miles \n");
                }

                else
                {
                    total = (saisieConvertie_a * conversion_mi);
                    Console.WriteLine(saisie_a + " Miles = " + total + " Kilomètres \n");
                }
            }
            else
            {
                Console.WriteLine("Erreur de saisie");
            }
            
            Console.ReadLine();
        }
    }
}


            
        