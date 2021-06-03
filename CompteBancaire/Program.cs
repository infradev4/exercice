using System;

namespace CompteBancaire
{
    //définition d'une classe commence par le mot-clé "class"
    public class CompteBancaire
    {
        //la définition des champs (attributs) de la classe
        public string titulaire;
        public double solde;
        public string devise;

        //la définition des méthodes de la classe
        //les méthodes utilisent (et modifient) les valeurs des attributs
        public void Crediter(double montant)
        {
            solde = solde + montant;
        }

        public void Debiter (double montant)
        {
            solde = solde - montant;
        }
    }
    
    /*
    Ce code utilise la classe CompteBancaire définie plus haut pour créer le compte de Jean et y effectuer 
    deux opérations.
    */

    static void Main(string[] args)
    {
        //déclaration d'un nouvel objet Oussama
        CompteBancaire CompteOussama;
        // instanciation de l'objet Oussama
        CompteOussama = new CompteBancaire();
        // affectations de valeurs aux attributs de la class CompteBancaire
        CompteOussama.titulaire = "Oussama";
        CompteOussama.solde = 0;
        CompteOussama.devise = "euro";
        
        // appels des méthodes de la class dans notre objet
        CompteOussama.Crediter(850);


    }


    /*
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    */
}
