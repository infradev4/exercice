using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteBancaire
{
    //classe dérivée correspondent à une spécialisation de la classe "CompteBancaire"
    //un compte épargne est un type particulier de compte bancaire.
    //On peut débiter ou créditer un compte épargne exactement comme un compte bancaire sans avoir à les redéfinir
    public class CompteEpargne : CompteBancaire //les deux-points spécifient que la classe CompteEpargne hérite de la classe CompteBancaire
    {
        private double tauxInteret;
        double interets;
        // appel du constructeur de la classe CompteBancaire
        // le mot-clé "base" permet d'accéder à la classe parente
        public CompteEpargne(string leTitulaire, double soldeInitial, string laDevise, double leTauxInteret): base(leTitulaire, soldeInitial, laDevise)
        {
            this.tauxInteret = leTauxInteret;
        }

        // Calcule et ajoute les intérêts au solde du compte
        public void AjouterInterets()
        {
            // calcul des intérêts sur le solde
            interets = solde * tauxInteret;
            // ajout des intérêts au solde
            //Solde += interets;
            solde = solde + interets;
        }
        // // Redéfinition de la méthode Debiter de la class CompteBancaire avec le mot-clé override
        public override void Debiter(double montant)
        {
            // Le montant maximal d'un retrait est la moitié du solde actuel
            if (montant <= Solde / 2)
                Solde = Solde - montant;
        }

        //// Redéfinition de la méthode Decrire de la class CompteBancaire avec le mot-clé override
        public override string Decrire()
        {
            return base.Decrire() + ". Son taux d'intérêt est de " + (tauxInteret * 100) + "%.";
        }
    }
}
