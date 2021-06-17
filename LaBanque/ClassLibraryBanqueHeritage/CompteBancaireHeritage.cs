using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanqueHeritage
{
    public class CompteBancaireHeritage
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

        // Constructeur
        public CompteBancaireHeritage(string leTitulaire, double soldeInitial, string laDevise)
        {
            titulaire = leTitulaire;
            solde = soldeInitial;
            devise = laDevise;
        }

        // Ajoute un montant au compte
        public void Crediter(double montant)
        {
            //solde = solde + montant;
            solde += montant;
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
    }
}
