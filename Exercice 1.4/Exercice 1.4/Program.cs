using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrer;
            string [] tableau;

            string entrerA;
            string entrerB;

            double entrerConvertieA;//2
            double entrerConvertieB; //1
            double entrerConvertieC;//2

            bool entrertesteA;
            bool entrertesteB;

            Console.WriteLine("Inversion de 2 valeurs");
            Console.WriteLine("Veuillez entrer deux nombres séparés par un espace");
            entrer = Console.ReadLine();

            tableau = entrer.Split(' ');

            entrerA = tableau[0];
            entrerB = tableau[1];

            entrertesteA = double.TryParse(entrerA, out entrerConvertieA);
            entrertesteB = double.TryParse(entrerB, out entrerConvertieB);


            entrerConvertieC = entrerConvertieB; 
            entrerConvertieB = entrerConvertieA; 
            entrerConvertieA = entrerConvertieC; 
                        
            if (entrertesteA && entrertesteB == true)
            {
                //pour afficher la valeur des variables entrerConvertieA entrerConvertieB
                Console.WriteLine("{0} {1}",entrerConvertieA,entrerConvertieB);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Erreur de saisie");
                Console.ReadLine();
            }
        }
    }
}

