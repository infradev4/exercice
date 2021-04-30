using System;

namespace Exercice_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEntrer;
            int nombreConverti;
            bool nombreTeste;
            int index;
            int totalPremier;

            Console.WriteLine("Programme de calcul des Nombres premiers parfaits");
            Console.WriteLine("Entrer un nombre entier :");
            nombreEntrer = Console.ReadLine();

            nombreTeste = int.TryParse(nombreEntrer,out nombreConverti);

            if(nombreTeste)
            {
                for (index = 2; nombreConverti => index; index++)
                {
                    totalPremier = (nombreConverti % index);
                    if (totalPremier == 0)
                    { }
                }
            }
        




            Console.ReadLine();
        }
    }
}
