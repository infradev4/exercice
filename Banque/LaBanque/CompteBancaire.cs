using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassCompteBancaire;

namespace ClassCompteBancaire
{
    class CompteBancaire
    {
        //la définition des champs (attributs) de la classe CompteBancaire
        //private string titulaire; //  =>  public string titulaire;
        private Client titulaire; // type string => type Client
        private double solde; //public double solde;
        private string devise;  //public string devise;

        //Les accesseurs est une méthode permetent de modifier les attributs privés
        public Client Titulaire // public string Titulaire (avant d'avoir utilise la class Client)
        {
            get { return titulaire; }
            //string titulaireCompte = compteChat.Titulaire;    // en lecture (getter)
            //Ici, j'affiche la valeur de "titulaire" avec "titulaireCompte"
            private set { titulaire = value; }
        }
        public double Solde
        {
            get { return solde; }
            private set { solde = value; }
        }
        public string Devise
        {
            get { return devise; }
            private set { devise = value; }
        }
        //la définition des méthodes de la classe
        //les méthodes utilisent (et modifient) les valeurs des attributs
        public void Crediter(double montant)
        {
            solde = solde + montant;
            //solde += montant;
        }
        public void Debiter(double montant)
        {
            solde = solde - montant;
            //solde -= montant;
        }
        //description d'un compte bancaire dans la class afin de ne pas avoir à le faire pour chaque objet
        // Renvoie la description d'un compte
        public string Decrire()
        {
            string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
            return description;
        }
        //le constructeur me peremt d'instancier la class CompteBancaire avec des valeurs par defaut 
        //afin de ne pas etre oblige de complete a chaque instanciation des informations repetitives.
        //public CompteBancaire(double soldeInitial, /*string*/Client leTitulaire, string laDevise)
        public CompteBancaire(double soldeInitial, Client leTitulaire, string laDevise)
        {
            solde = soldeInitial;
            titulaire = leTitulaire;
            devise = laDevise;
        }
    }
}

