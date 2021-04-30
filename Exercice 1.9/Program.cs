using System;

namespace Exercice_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int diviseur = 2;
            int total;
            int entrerConvertie;

            Console.WriteLine("Recherche des diviseurs d’un nombre");
            Console.WriteLine("Entrer un nombre entier :");

            string entrer=Console.ReadLine();

            bool entrerTester=int.TryParse(entrer,out entrerConvertie);

            if (entrerTester)
            {
                for (diviseur = 2; diviseur < entrerConvertie; diviseur++)
                {
                    total = (entrerConvertie % diviseur);
                    Console.WriteLine("diviseur " + diviseur + " " + "total " + total);
                    //Console.WriteLine(total);

                if (total == 0)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
