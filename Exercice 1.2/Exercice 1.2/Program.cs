using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rayonBrut;
            double rayonConvertie;
            bool rayonTeste = true;

            double aire;
            double volume;

            Console.WriteLine("Calcul de l’aire et du volume d’une sphère");
            Console.WriteLine("Enter le rayon d'une sphère");
            rayonBrut=Console.ReadLine();

            rayonTeste = double.TryParse(rayonBrut, out rayonConvertie);

            if (rayonTeste == true)
            {
                //Math.PI = Pi = 3.15
                //Math.Pow(rayonConvertie, 2) = rayonConvertie * rayonConvertie = rayonConvertie²
                //Math.Pow(rayonConvertie, 3) = rayonConvertie*rayonConvertie*rayonConvertie = rayonConvertie au cube

                aire = (4 * Math.PI * Math.Pow(rayonConvertie, 2));
                volume = ((4 / 3) * Math.PI * Math.Pow(rayonConvertie, 3));
                Console.WriteLine("Son aire = " + aire);
                Console.WriteLine("Son volume = " + volume);
                Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("Erreur de saisie");
                Console.ReadLine();

            }

        }
    }
}
