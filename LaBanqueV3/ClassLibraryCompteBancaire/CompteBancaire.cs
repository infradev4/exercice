using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteBancaire
{
    public abstract class CompteBancaire
    {
        private string titulaire;
        protected double solde; //private => protected permettant l'utilisation par une classe dérivée de l'attribut
        private string devise;

        public CompteBancaire(string leTitulaire, double soldeInitial, string laDevise)
        {
            titulaire = leTitulaire;
            solde = soldeInitial;
            devise = laDevise;
        }

        public double Solde
        {
            get { return solde; }
            protected set { solde = value; }// mutateur protégé pour la modification
        }

        public string Devise
        {
            get { return devise; }
        }

        public string Titulaire
        {
            get { return titulaire; }
        }

        public void Crediter(double montant)
        {
            solde = solde + montant;
        }
        //public void Debiter(double montant)
        //{
        //    solde = solde - montant;
        //}

        //La méthode Debiter est maintenant abstraite
        //La méthode est déclarée mais pas définie.
        //Ce sera aux classes qui héritent de CompteBancaire de fournir la méthode
        public abstract void Debiter(double montant);

        // une méthode virtuelle (virtual) fournit un comportement par défaut dans une classe
        // Une méthode virtuelle définit un comportement
        public virtual string Decrire()
        {
            return "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
        }
    }
}
