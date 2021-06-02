using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille1
{
    class Bouteille
    {

     public string name; 
     public bool etatouvert;
     public float conteneurEnPourcentage;
     public float contenanceEnLittre;

        public void name (string
        {
            bool etatouvert = true;
                        
            Console.WriteLine("la bouteille est ouverte: {0}", etatouvert);
        }
 
        public static void Main()
        {
            bool etatouvert = true;
                        
            Console.WriteLine("la bouteille est ouverte: {0}", etatouvert);
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
