using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteBancaire
{
    // Définit un compte bancaire
    public class CompteBancaire
    {
        private string titulaire; // Titulaire du compte
        private double solde;     // Solde du compte
        private string devise;    // Devise du compte

        public string Titulaire
        {
            get { return titulaire; }
        }

        public double Solde
        {
            get { return solde; }
        }

        public string Devise
        {
            get { return devise; }
        }
        //Il prendra uniquement le titulaire en paramètre, et initialisera solde et devise avec leurs valeurs par défaut
        public CompteBancaire(string titulaire)
        {
            this.titulaire = titulaire;
            solde = 0;
            devise = "euros";
        }

        // Constructeur qui initialise les attributs du compte créé "classic"
        public CompteBancaire(string leTitulaire, double soldeInitial, string laDevise)
        {
            titulaire = leTitulaire;
            solde = soldeInitial;
            devise = laDevise;
        }

        // Ajoute un montant au compte
        public void Crediter(double montant)
        {
            solde = solde + montant;
        }

        // Retire un montant au compte
        public void Debiter(double montant)
        {
            solde = solde - montant;
        }

        // Renvoie la description du compte
        public string Decrire()
        {
            string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
            return description;
        }
        public override string ToString()
        {
            return "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
        }
    }

}
