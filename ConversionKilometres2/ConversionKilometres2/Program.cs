using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKilometres1
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie_a;
            float total;
            float conversion_mi = 1.60F;
           
            Console.WriteLine("Programme de conversion Kilomètres <-> Miles.");
            Console.WriteLine("Saisir une valeur et son unité de mesure (séparés par un espace) :");

            saisie_a = Console.ReadLine();



            string unite = saisie_a.Substring(saisie_a.Length - 2, 2); //extraire l'unite Mi ou Km (2car). Je recupere 2 char en                partent de la fin (-2)

            float nombre = float.Parse(saisie_a.Substring(0, saisie_a.Length - 3)); // extraire le nombre avant l'espace vide 

            Console.WriteLine();

            if (unite != "mi")
            {
                total = (nombre / conversion_mi);
                Console.WriteLine(nombre + " Kilomètres = " + total + " Miles \n");
            }

            else
            {
                total = (nombre * conversion_mi);
                Console.WriteLine(nombre + " Miles = " + total + " Kilomètres \n");
            }

            Console.ReadLine();
        }
    }
}