using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanqueHeritage
{
    //classe dérivée correspondent à une spécialisation de la classe "CompteBancaire"
    //un compte épargne est un type particulier de compte bancaire.
    //On peut débiter ou créditer un compte épargne exactement comme un compte bancaire sans avoir à les redéfinir
    public class CompteEpargne : CompteBancaire //les deux-points spécifient que la classe CompteEpargne hérite de la classe CompteBancaire
    {
        private double tauxInteret;

        public CompteEpargne(string leTitulaire, double soldeInitial, string laDevise, double leTauxInteret)
            : base(leTitulaire, soldeInitial, laDevise)
        // appel du constructeur de la classe CompteBancaire
        // le mot-clé "base" permet d'accéder à la classe parente
        {
            tauxInteret = leTauxInteret;
        }

        // Calcule et ajoute les intérêts au solde du compte
        public void AjouterInterets()
        {
            // calcul des intérêts sur le solde
            double interets = solde * tauxInteret;
            // ajout des intérêts au solde
            solde += interets;
        }
    }
}
