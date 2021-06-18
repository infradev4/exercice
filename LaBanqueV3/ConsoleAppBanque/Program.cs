using ClassLibraryCompteBancaire;
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
            double montantTransfert;

            CompteEpargne compteOussama = new CompteEpargne("Oussama", 100, "euros", tauxInteret);
            

            //// appel des méthodes de CompteBancaire sur le compte épargne
            //compteOussama.Debiter(1000);
            //compteOussama.Crediter(1500);
            //compteOussama.AjouterInterets();
            //Console.WriteLine(compteOussama.Decrire()); // Si j'utilise la methode  => public string decrire()
            //Console.WriteLine(compteOussama.ToString()); // Si j'utilise la methode  => override string ToString()

            CompteCourant compteAmelyne = new CompteCourant("Amelyne", 0, "euros", "12345", -2500);
            compteAmelyne.Debiter(1000);
            compteAmelyne.Debiter(4000);//le second retrait de 4000 dollars n'a pas lieu, puisqu'il aurait fait passer le solde en dessous du découvert maximal autorisé "-2500".
            Console.WriteLine(compteAmelyne.Decrire()); // Si j'utilise la methode  => public string decrire()

            //CompteCourant compteOussamaCourant = new CompteCourant("Oussama", 1000, "euros", "678910", -500);
            //Console.Write("Entrez le montant du transfert : ");
            //montantTransfert = Convert.ToDouble(Console.ReadLine());
            //compteOussamaCourant.Debiter(montantTransfert);
            //Console.WriteLine(compteOussamaCourant.Decrire());
            //compteAmelyne.Crediter(montantTransfert);
            //Console.WriteLine(compteAmelyne.Decrire());

            CompteCourant compteOussamaCourant = new CompteCourant("Oussama", 1000, "euros", "678910", -500);
            
            compteOussamaCourant.Transferer(1000,compteAmelyne);
            Console.WriteLine(compteOussamaCourant.Decrire());
            
            Console.WriteLine(compteAmelyne.Decrire());

            Console.ReadKey();


            //int[] tab = new int[6]{1,5,2,7,3,3};
            //le plus petit?
            //le nombre le plus recurent
            // increment 2


            //Console.ReadKey();

        }
    }
}
