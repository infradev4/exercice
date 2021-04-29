using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string valeurs;

            Console.WriteLine("Tri de nombres");
            Console.WriteLine("Entrer des chiffres :");

            valeurs = Console.ReadLine();

            //Console.WriteLine(valeurs.Length);

            if (valeurs.Length < 2)
            {
                Console.WriteLine(valeurs);
            }
            else 
            {
                Console.WriteLine("Probleme");
            }
            Console.ReadLine();
        }
    }
}