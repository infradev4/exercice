using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanqueHeritage
{
    // Définit un compte bancaire
    public class CompteBancaire
    {
        private string titulaire; // Titulaire du compte
        protected double solde;   //private => protected (pour permettre à la classe dérivée CompteEpargne d'accéder à l'attribut solde)
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

        public CompteBancaire()
        {
        }

        // Constructeur
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

        public override string ToString()
        {
            return "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
        }
        // Renvoie la description du compte
        //public string decrire()
        //{
        //    return "le solde du compte de " + titulaire + " est de " + solde + " " + devise;
        //}
    }

}
