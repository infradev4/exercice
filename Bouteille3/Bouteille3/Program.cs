using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille3
{
    class Bouteille
    {

        private string name;
        public bool etatouvert;
        public float conteneurEnPourcentage;
        public float contenanceEnLittre;


        public void SetName(string _newname)
        {
            this.name = _newname;
        }
        private string GetName()
        {
            return this.name;
        }

        public Bouteille()
        {
            this.SetName("unknown");
        }

        public Bouteille(string name)
        {
            this.SetName(name);
        }


        public override string ToString()
        {
            return GetName();
        }


    }



    class Program
    {
        static void Main(string[] args)
        {

            Bouteille mabouteilleA;

            mabouteilleA = new Bouteille();
            mabouteilleA.SetName("eau");
            mabouteilleA.etatouvert = true;
            mabouteilleA.conteneurEnPourcentage = 80;
            mabouteilleA.contenanceEnLittre = 1;

            Bouteille mabouteilleB;

            mabouteilleB = new Bouteille("Coca");

            Console.WriteLine(mabouteilleA.ToString());
            Console.WriteLine(mabouteilleB.ToString());
            Console.ReadLine();

        }
    }

}
