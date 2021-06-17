using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanqueHeritage
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
            Console.WriteLine(comptePaul.Decrire()); // Affiche 600 $

        }
    }
}
