using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bouteille;

namespace Bouteille
{
        class Program
    {
        static void Main(string[] args)
        {
            Bouteille mabouteilleA;

            mabouteilleA = new BouteilleClass.Bouteille("eau", 1);
            mabouteilleA.SetEtatOuvert();

            Console.WriteLine(mabouteilleA.ToString());
            mabouteilleA.ViderTout();
            bool ok = mabouteilleA.RemplirTelPourcentage(20);
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
