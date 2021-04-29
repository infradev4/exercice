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
            int saisieConvertie_a;
            float total;
            bool saisie_a_Ok;
            float conversion_mi = 1.60F;
            
            Console.WriteLine("Programme de conversion Kilomètres -> Miles.");
            Console.WriteLine("Saisir une valeur en Kilomètres :");
            
            saisie_a = Console.ReadLine();
            Console.WriteLine();

            saisie_a_Ok = int.TryParse(saisie_a, out saisieConvertie_a);

            if (saisie_a_Ok)
            {
                total = (saisieConvertie_a / conversion_mi);
                Console.WriteLine(saisie_a + " Kilomètres = " + total + " Miles \n");
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