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
            int k;
            int somdiv;
            int nbr;

            Console.WriteLine("Programme de recherche des nombres parfaits");
            Console.WriteLine("Combien de nombre parfaits souhaitez-vous afficher ? :");

            a = Console.ReadLine();
            saisie = int.Parse(a);
            nbr = 2;
            
            while (compt != saisie)
            {
                somdiv = 1;
                k = 2;
                
                    while(k <= nbr/2 )
                    {
                        if (nbr % k == 0) 
                        somdiv += k;
                        k++;
                    }
                    
                    if (somdiv == nbr)
                    {
                        Console.WriteLine(nbr+" est un nombre parfait");
                        compt++;
                    }
                    nbr++;
            }
        }
    }
}
