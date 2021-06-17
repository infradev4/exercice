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
    public class CompteCourant : CompteBancaire //les deux-points spécifient que la classe CompteEpargne hérite de la classe CompteBancaire
    {
        private string numeroCB;
        private double decouvertMaxi;

        // Constructeur
        // le mot-clé "base" permet d'accéder à la classe parente "CompteBancaire"
        public CompteCourant(string leTitulaire, double soldeInitial, string laDevise, string numeroCB, double decouvertMaxi)
            : base(leTitulaire, soldeInitial, laDevise)  //=> appel au constructeur constructeur de la classe CompteBancaire
        {
            this.numeroCB = numeroCB;
            this.decouvertMaxi = decouvertMaxi;
        }
        // Retire un montant au compte
        //public void Debiter(double montant)
        //{
        //    solde = solde - montant;
        //}

        // Redéfinition de la méthode Debiter de la class CompteBancaire avec le mot-clé override
        public override void Debiter(double montant)
        {
            // on n'effectue le débit que si le solde final reste supérieur au découvert
            if (Solde - montant >= decouvertMaxi)
                Solde = Solde - montant;
        }
    }
}
