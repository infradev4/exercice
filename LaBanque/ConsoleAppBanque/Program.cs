using ClassLibraryBanque;
using CompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanque
{
    //class Program
    class CompteBancaire
    {
        static void Main(string[] args)
        {
            
            //Déclaration et instanciation d'un nouvel objet sur une meme ligne
            CompteBancaire compteOussama = new CompteBancaire();
            //    ou
            //déclaration d'un nouvel objet Oussama
            //CompteBancaire compteOussama;
            //instanciation de l'objet Oussama
            //compteOussama = new CompteBancaire();
            

            
            //affectations de valeurs aux attributs de la class CompteBancaire
            compteOussama.titulaire = "Oussama";
            compteOussama.solde = 0;
            compteOussama.devise = "euro";

            // appels des méthodes de la class dans notre objet
            compteOussama.Crediter(850);
            compteOussama.Debiter(100);

            ////déclaration d'un nouvel objet Amelyne sur une ligne
            //CompteBancaire compteAmelyne = new CompteBancaire();

            //compteAmelyne.titulaire = "Amelyne";
            //compteAmelyne.solde = 125;
            //compteAmelyne.devise = "euro";

            //Console.WriteLine("Entrez le montant de votre transfert : ");

            //double montantTransfert;
            //montantTransfert = Convert.ToDouble(Console.ReadLine());

            //compteOussama.Debiter(montantTransfert);
            //compteAmelyne.Crediter(montantTransfert);

            Console.WriteLine(compteOussama.Decrire());
            //Console.WriteLine(compteAmelyne.Decrire());

            //Remplacer par la methode "Decrire"
            //string description = "Le solde du compte de " + compteOussama.titulaire + 
            //                    " est de " + compteOussama.solde + 
            //                    " " + compteOussama.devise;

            Console.WriteLine(compteOussama.Decrire());
            

            //déclaration et instanciation d'un nouvel objet en utilisant son constructeur
            //CompteBancaire compteChat = new CompteBancaire(0, "Chat", "euro");

            //appels de méthodes avec le constructeur

            //string titulaireCompte = compteChat.Titulaire;    // en lecture (getter)
            //compteChat.Titulaire = "Galere";    // en écriture (setter)
            //                                    //compteChat.Solde = 9;               // en écriture (setter)
            //                                    //compteChat.Devise = "MAD";          // en écriture (setter)

            //compteChat.Crediter(150);
            //compteChat.Debiter(25);
            //Console.WriteLine(compteChat.Decrire());
        }
    }
}
