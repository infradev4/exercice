using System;

namespace CompteBancaire
{
    //définition d'une classe commence par le mot-clé "class"
    public class CompteBancaire
    {
        //la définition des champs (attributs) de la classe CompteBancaire
        //public string titulaire;
        private string titulaire;

        //public double solde;
        private double solde;

        //public string devise;
        private string devise;

        //Les accesseurs est une méthode permetent de modifier les attributs privés

        public string Titulaire
        {
            get {return titulaire;}
            set {titulaire = value;}
        }

        public double Solde
        {
            get {return solde;}
            set {solde = value;}
        }

        public string Devise
        {
            get {return devise;}
            set {devise = value;}
        }

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
        //description d'un compte bancaire dans la class afin de ne pas avoir à le faire pour chaque objet
        // Renvoie la description d'un compte
        public string Decrire ()
        {
            string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
            return description;
        }
        //le constructeur me peremt d'instancier la class CompteBancaire avec des valeurs par defaut 
        //afin de ne pas etre oblige de complete a chaque instanciation des informations repetitives.
        public CompteBancaire(double soldeInitial, string leTitulaire, string laDevise)
        {
            solde = soldeInitial;
            titulaire = leTitulaire;
            devise = laDevise;
        }
    }
    
    /*
    Ce code utilise la classe CompteBancaire définie plus haut pour créer le compte de xxx et y effectuer 
    des opérations.
    */

     class Program
    {
        static void Main(string[] args)
        {
        /*
        Déclaration et instanciation d'un nouvel objet sur une meme ligne
        CompteBancaire compteOussama = new CompteBancaire();
            ou
        déclaration d'un nouvel objet Oussama
        CompteBancaire compteOussama;
        instanciation de l'objet Oussama
        compteOussama = new CompteBancaire();
        */
        
        /*
        // affectations de valeurs aux attributs de la class CompteBancaire
        compteOussama.titulaire = "Oussama";
        compteOussama.solde = 0;
        compteOussama.devise = "euro";

        // appels des méthodes de la class dans notre objet
        compteOussama.Crediter(850);
        compteOussama.Debiter(100);

        //déclaration d'un nouvel objet Amelyne sur une ligne
        CompteBancaire compteAmelyne = new CompteBancaire();

        compteAmelyne.titulaire = "Amelyne";
        compteAmelyne.solde = 125;
        compteAmelyne.devise = "euro";

        Console.WriteLine("Entrez le montant de votre transfert : ");
        
        double montantTransfert;
        montantTransfert = Convert.ToDouble(Console.ReadLine());
        
        compteOussama.Debiter(montantTransfert);
        compteAmelyne.Crediter(montantTransfert);

        Console.WriteLine(compteOussama.Decrire());
        Console.WriteLine(compteAmelyne.Decrire());
        
        Remplacer par la methode "Decrire"
        string description = "Le solde du compte de " + compteOussama.titulaire + 
                            " est de " + compteOussama.solde + 
                            " " + compteOussama.devise;
        
        Console.WriteLine(compteOussama.Decrire());
        */

        // déclaration et instanciation d'un nouvel objet en utilisant son constructeur
        CompteBancaire compteChat = new CompteBancaire(0,"Chat","euro");

        // appels de méthodes avec le constructeur
        compteChat.Crediter(150);
        compteChat.Debiter(25);
        Console.WriteLine(compteChat.Decrire());

        CompteBancaire compteTest = new CompteBancaire;

        compteTest.
        }
    }
}
