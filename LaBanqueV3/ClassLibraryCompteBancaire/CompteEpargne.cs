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
        // appel du constructeur de la classe CompteBancaire
        // le mot-clé "base" permet d'accéder à la classe parente
        public CompteEpargne(string leTitulaire, double soldeInitial, string laDevise, double leTauxInteret): base(leTitulaire, soldeInitial, laDevise)
        {
            tauxInteret = leTauxInteret;
        }

        // Calcule et ajoute les intérêts au solde du compte
        public void AjouterInterets()
        {
            // calcul des intérêts sur le solde
            double interets = solde * tauxInteret;
            // ajout des intérêts au solde
            //Solde += interets;
            solde = solde + interets;
        }
        // redéfinition de la méthode Debiter
        public override void Debiter(double montant)
        {
            // Le montant maximal d'un retrait est la moitié du solde actuel
            if (montant <= Solde / 2)
                Solde -= montant;
        }

        // Redéfinition de la méthode Decrire
        public override string Decrire()
        {
            return base.Decrire() + ". Son taux d'intérêt est de " + (tauxInteret * 100) + "%.";
        }
    }
}
