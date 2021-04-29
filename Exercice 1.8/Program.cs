using System;

namespace Exercice_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double anneeConvertie;
            double calculA;
            double calculB;
            double MilleNeufCents = 1900;


            Console.WriteLine("Programme d'identification d'année bissextile");
            Console.WriteLine("Entrée une année au format XXXX :");
            string annee = Console.ReadLine();

            bool anneeTest = double.TryParse(annee, out anneeConvertie);

            if (anneeTest == false)
            {
                Console.WriteLine("Erreur de saisie");
            }

            calculA = (anneeConvertie % 4);
            calculB = (anneeConvertie % 100);

            if (calculA % 4 == 0 & calculB % 100 != 0 || anneeConvertie == MilleNeufCents)
            {
                Console.WriteLine("Année bissextile");
            }
            else
            {
                Console.WriteLine("Année non-bissextile");
            }
                            Console.ReadLine();
        }
    }
}
