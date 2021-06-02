using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille1
{
    class Bouteille
    {
        //attributs: données représentent l'état de l'objet
        private string name; 
        public bool etatbouchon;
        public float conteneurEnPourcentage; 
        public float contenanceEnLittre;

        //propriété (lecture, écriture ou le calcul de la valeur des champs privé)
        public void SetName(string _newname)
        {
            this.name=_newname;
        }
        
        public string GetName()
        {
            return this.name;
        }
        
        public void SetEtatOuvert()
        {
            this.etatbouchon = true;
        }

        public void SetEtatFermer(bool _newetat)
        {
            this.etatbouchon = false;
        }
        
        public string GetBouchon()
        {
            if (this.etatbouchon == true)
            {
                return "ouvert";
            }
            else 
            {
                return "fermer";
            }
        }

        public void SetConteneur(float _newconteneur)
        {
            this.conteneurEnPourcentage = _newconteneur;
        }
        
        public float GetConteneur()
        {
            return this.conteneurEnPourcentage;
        }
        
        public void SetContenance(float _newcontenance)
        {
            this.contenanceEnLittre = _newcontenance;
        }
        
        public float GetContenance()
        {
            return this.contenanceEnLittre;
        }
        
        //Constructeur
        public Bouteille()
        {
            this.name= "unknown";
            this.etatbouchon = false;
            this.conteneurEnPourcentage = 100;
            this.contenanceEnLittre = 1.5F;
        }

        //Constructeur
        public Bouteille(string _name, float _contenanceEnLittre)
        {
            this.name = _name;
            this.etatbouchon = false;
            this.conteneurEnPourcentage = 100;
            this.contenanceEnLittre = _contenanceEnLittre;
        }

        ////méthodes et opérations applicables aux objets
        public bool Ouvrir()
        {
            if (this.etatbouchon == false)
            {
                this.etatbouchon = true;
                return true;
            }
            return false;
        }

        public bool Fermer()
        {
            if (this.etatbouchon == true)
            {
                this.etatbouchon = false;
                return false;
            }
            return true;
        }

        public bool ViderTout()
        {
            if (this.etatbouchon == true)
            {
                this.conteneurEnPourcentage = 0;
                return true;
            }
            return false;
        }

        public bool RemplirTout()
        {
            if (this.etatbouchon == true)
            {
                this.conteneurEnPourcentage = 100;
                return true;
            }
            return false;
        }
        
        public bool RemplirTelPourcentage()
        {
            if (this.etatbouchon == true)
            {
                this.conteneurEnPourcentage = 60;
                return true;
            }
            return false;
        }

        public bool ViderTelPourcentage()
        {
            if (this.etatbouchon == true)
            {
                this.conteneurEnPourcentage = 30;
                return true;
            }
            return false;
        }
        
        public override string ToString()
        {
            return "Je suis une bouteille d'" + this.name + " en etat " + this.etatbouchon + " avec un conteneur de " + this.contenanceEnLittre + "L et un contenant en pourcentage de " + this.conteneurEnPourcentage + " % ";
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Bouteille mabouteilleA;

            mabouteilleA = new Bouteille("eau", 1);
            mabouteilleA.SetEtatOuvert();
            
            Console.WriteLine(mabouteilleA.ToString());
            mabouteilleA.ViderTout();
            mabouteilleA.RemplirTelPourcentage();
            mabouteilleA.ViderTelPourcentage();
            Console.WriteLine(mabouteilleA.ToString());
            Console.ReadLine();

            
            Bouteille mabouteilleB;

            mabouteilleB = new Bouteille("sprite", 2);
            mabouteilleB.ViderTout();
            mabouteilleB.SetEtatFermer(true);

            Console.WriteLine(mabouteilleB.ToString());
            mabouteilleB.RemplirTout();
            Console.WriteLine(mabouteilleB.ToString());
            Console.ReadLine();
            
        }
    }
}
