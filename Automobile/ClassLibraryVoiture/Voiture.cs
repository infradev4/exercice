using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Voiture
    {
        private int compteurEnKm;
        private List<Roue> mesRoues;
        private Moteur monMoteur;

        public int CompteurEnKm
        {
            get {return compteurEnKm; }
            //private set { compteurEnKm = value; }
        }
        public List<Roue> MesRoues
        {
            get {return mesRoues; }
        }
        public Moteur MonMoteur//boum magie
        {
            get {return monMoteur; }
        }
        //la définition des méthodes de la classe
        //les méthodes utilisent (et modifient) les valeurs des attributs
        
        public void Arreter()
        { 
            monMoteur = true;
        }
        public void Avancer()
        {
            mesRoues = true;// une roue et pas un bool> boum methode maRoue.jeRoule maybe??
        }
        public void Demarrer()
        {
            monMoteur = true;
        }


        //Constructeur par defaut
        public Voiture()
            :this(0,
            new List<Roue>() { new Roue(), new Roue(), new Roue(), new Roue() },
            new Moteur())

        {
        }
        
        private Voiture(int compteurEnKm, List<Roue> mesRoues, Moteur monMoteur)
        {
            this.compteurEnKm = compteurEnKm;
            this.mesRoues = mesRoues;
            this.monMoteur = monMoteur;
        }
        //Constructeur classique
        private Voiture(int compteurEnKm, bool tourne, int diametre, bool estDemarre, int nbCV)
        : this(compteurEnKm,
             new List<Roue>() { new Roue(tourne, diametre), new Roue(tourne, diametre), new Roue(tourne, diametre), new Roue(tourne, diametre) },
             new Moteur(estDemarre, nbCV))
        {
            //pour le compteur
            //this.compteurEnKm = compteurEnKm;

            //pour les roues
            //this.mesRoues = new List<Roue>();
            //this.mesRoues[0] = new Roue(tourne, diametre);
            //this.mesRoues[1] = new Roue(tourne, diametre);
            //this.mesRoues[2] = new Roue(tourne, diametre);
            //this.mesRoues[3] = new Roue(tourne, diametre);

            //pour le moteur
            //this.monMoteur = new Moteur(estDemarre, nbCV);
        }

        //Constructeur par copie
        public Voiture(Voiture _voitureARecopier)
        {
            //pour le compteur
            this.compteurEnKm = _voitureARecopier.compteurEnKm;

            //pour les roues

            //this.mesRoues = _voitureARecopier.mesRoues; //FAUX, faux et Faux!

            this.mesRoues = new List<Roue>();
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[0]));//c pas un get pour une liste? 
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[1]));
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[2]));
            this.mesRoues.Add(new Roue(_voitureARecopier.mesRoues[3]));

            //pour le moteur
            this.monMoteur = new Moteur(_voitureARecopier.monMoteur);
        }

    }
}
