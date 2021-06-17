using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanqueHeritage
{
    //  ":" spécifient que la classe CompteEpargne hérite de la classe CompteBancaireHeritage
    //relation d'héritage entre deux classes.
    public class CompteEpargne: CompteBancaireHeritage  
    {
        private double tauxInteret;

        public CompteEpargne(string leTitulaire, double soldeInitial, string laDevise, double leTauxInteret)
            : base(leTitulaire, soldeInitial, laDevise)
        // appel du constructeur de la classe CompteBancaireHeritage
        // le mot-clé "base" permet d'accéder à la classe parente
        {
            tauxInteret = leTauxInteret;
        }

        // Calcule et ajoute les intérêts au solde du compte
        public void AjouterInterets()
        {
            // calcul des intérêts sur le solde
            double interets = Solde * tauxInteret;
            // ajout des intérêts au solde
            Solde += interets;
        }
    }
}
