using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBanque
{
    // Modéliser un client
    public class Client
    {
        private int numero; // Numéro de compte
        private string nom; // Nom
        private string prenom; // Prénom
        private List<CompteBancaire> comptes; // Il y aura une ou plusieurs références à "CompteBancaire" dont un client est titulaire d'ou la Liste 
        public int Numero
        {
            get { return numero; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public string Prenom
        {
            get { return prenom; }
        }
        //un client peut avoir plusieurs compte bancaire
        public List<CompteBancaire> Comptes
        {
            get { return comptes; }
        }
        //Construteur par defaut 
        public Client() : this(1,"","")
        {
        }
        //Constructeur Classique
        public Client(int leNumero, string leNom, string lePrenom)//,List<CompteBancaire> Comptes)
        {
            numero = leNumero;
            nom = leNom;
            prenom = lePrenom;
            comptes = new List<CompteBancaire>();
        }
    }
}
