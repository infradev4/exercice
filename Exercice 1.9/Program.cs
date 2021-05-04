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

            Console.WriteLine("Recherche des diviseurs d’un nombre");
            Console.WriteLine("Entrer un nombre entier :");

            string entrer=Console.ReadLine();

            bool entrerTester=int.TryParse(entrer,out entrerConvertie);

            if (entrerTester)
            {
                for (diviseur = 2; diviseur < entrerConvertie; diviseur++)
                {
                    reste = (entrerConvertie % diviseur);
                    Console.WriteLine("diviseur " + diviseur + " " + "reste " + reste);
                    
                    if (diviseur == entrerConvertie & diviseur == 1 & reste == 1)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
