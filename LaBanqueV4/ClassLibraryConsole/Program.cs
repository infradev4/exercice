using ClassLibraryCompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("Pierre", 100, "dollars");
            Console.WriteLine(compte.Decrire());

            //Console.WriteLine("Avant la 1ère création : " + CompteBancaire.GetNumeroProchainCompte());
            //CompteBancaire comptePierre = new CompteBancaire("Pierre");

            //Console.WriteLine("Avant la 2ème création : " + CompteBancaire.GetNumeroProchainCompte());
            //CompteBancaire comptePaul = new CompteBancaire("Paul");

            //Console.WriteLine("Avant la 3ème création : " + CompteBancaire.GetNumeroProchainCompte());
            //CompteBancaire compteJacques = new CompteBancaire("Jacques");

            //Console.WriteLine("Après la 3ème création : " + CompteBancaire.GetNumeroProchainCompte());

            //Console.WriteLine(comptePierre);
            //Console.WriteLine(comptePaul);
            //Console.WriteLine(compteJacques);

            Console.ReadKey();
        }
    }
}
