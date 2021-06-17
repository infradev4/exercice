using ClassLibraryBanqueHeritage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanque
{
    public class Program
    {
        static void Main(string[] args)
        {

            double tauxInteret = 0.05;  // taux d'intérêt : 5%
            CompteEpargne comptePaul = new CompteEpargne("paul", 100, "dollars", tauxInteret);

            // appel des méthodes de CompteBancaire sur le compte épargne
            comptePaul.Debiter(1000);
            comptePaul.Crediter(1500);
            //Console.WriteLine(comptePaul.Decrire()); // Si j'utilise la methode  => public string decrire()
            Console.WriteLine(comptePaul.ToString()); // Si j'utilise la methode  => override string ToString()

            Console.ReadKey();


            //int[] tab = new int[6]{1,5,2,7,3,3};
            //le plus petit?
            //le nombre le plus recurent
            // increment 2


            //Console.ReadKey();

        }
    }
}
