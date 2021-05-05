using System;

namespace Exercice_1._10C
{
    class Program
    {
        static void Main(string[] args)
        {
            int compt = 0; 
            int n; 
            int k; 
            int somdiv; 
            int nbr;
            
            Console.WriteLine("Programme de recherche des nombres parfaits");
            Console.WriteLine("Combien de nombre parfaits souhaitez-vous afficher ? :");
            
            n = Int32.Parse(Console.ReadLine());
            nbr = 2;

            while (compt != n)
            { 
                somdiv = 1;
                k = 2;
                
                while(k <= nbr/2 )
                {
                    if (nbr % k == 0) 
                    somdiv += k ;
                    k++;
                } 
            }
        }
    }
}
