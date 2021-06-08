using System;

namespace BouteilleCorrectionB
{
    public class Program
    {
        //la définition des champs (attributs) de la classe Bouteille
        private double contenanceEnL;
        private double contenuEnPourcentage;
        private bool ouvert;

        //Les accesseurs pour modifier les attributs privés
        public double ContenanceEnL
        {
            get {return contenanceEnL;}
            private set {contenanceEnL = value;}
        }

        public double ContenuEnPourcentage
        {
            get {return contenuEnPourcentage;}
            private set {contenuEnPourcentage = value;}
        }

        public bool Ouvert
        {
            get {return ouvert;}
            private set {ouvert = value;}
        }

        //la définition des méthodes de la classe
        //les méthodes utilisent (et modifient) les valeurs des attributs



        


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
