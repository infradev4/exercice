using System;

namespace Exercice_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int diviseur = 2;
            int reste;
            int entrerConvertie;
            bool entrerTester;
            string entrer;

            Console.WriteLine("Recherche des diviseurs d’un nombre");
            Console.WriteLine("Entrer un nombre entier :");

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
                /*
                if (diviseur == entrerConvertie & reste == 0)
                {
                    break;
                }
                */
            }
                    Console.ReadLine();
        }
    }
}
