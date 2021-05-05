using System;

namespace Exercice_1._10C
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int compt = 0; 
            int saisie;
            int diviseur;
            int sommeDiviseurs;
            int nombre = 2;

            Console.WriteLine("Programme de recherche des nombres parfaits");
            Console.WriteLine("Combien de nombre parfaits souhaitez-vous afficher ? :");

            a = Console.ReadLine();
            saisie = int.Parse(a);
            
            while (compt != saisie)
            {
                sommeDiviseurs = 1;
                diviseur = 2;
                
                    while(diviseur <= nombre/2 )
                    {
                        if (nombre % diviseur == 0) 
                        sommeDiviseurs += diviseur;
                        diviseur++;
                    }
                    
                    if (sommeDiviseurs == nombre)
                    {
                        Console.WriteLine(nombre+" est un nombre parfait");
                        compt++;
                    }
                    nombre++;
            }
        }
    }
}
