using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
     //définition d'une classe commence par le mot-clé "class"
     //public pour endre accesible
    public class CompteBancaire
    {
        //la définition des champs (attributs) de la classe CompteBancaire
        //public string titulaire;
        //private string titulaire; 
        private Client titulaire; // type string => type Client
                                  //Un client est le titulaire d'un compte bancaire.

        //public double solde;
        private double solde;

        //public string devise;
        private string devise;

        //Les accesseurs est une méthode permetent de modifier les attributs privés
        //public string Titulaire
        public Client Titulaire
        {
            get {return titulaire;}
        //string titulaireCompte = compteChat.Titulaire;    // en lecture (getter)
        //Ici, j'affiche la valeur de "titulaire" avec "titulaireCompte"
            set {titulaire = value;}    
        }
        
        public double Solde
        {
            get {return solde;}
           private set {solde = value;}
        }
        public string Devise
        {
            get {return devise;}
           private set {devise = value;}
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
        //public string Decrire ()
        //{
        //    string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
        //    return description;
        //}
        //description d'un compte bancaire avec les information de la class Client en supplement
        public string Decrire()
        {
            string descriptionTitulaire = titulaire.Prenom + " " + titulaire.Nom + " numero de compte : " + titulaire.Numero;
            string description = "Le solde du compte de " + descriptionTitulaire + " est de " + solde + " " + devise;
            return description;
        }

        //le constructeur me peremt d'instancier la class CompteBancaire avec des valeurs par defaut 
        //afin de ne pas etre oblige de complete a chaque instanciation des informations repetitives.
        public CompteBancaire(double soldeInitial, Client leTitulaire, string laDevise) //string leTitulaire => Client leTitulaire
        {
            solde = soldeInitial;
            titulaire = leTitulaire;
            devise = laDevise;
        }
    }
}
