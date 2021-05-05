using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            double nombreConvertie;
            bool nombreTest;
            //test
            
            double diviseur;

            //double valeurRacine;
            //int valeurRacineEntier;
            double testA;

            Console.WriteLine("Programme de détermination des nombres premiers.");
            Console.WriteLine("Entrer un chiffre pour déterminier si il est un entier");
            nombre = Console.ReadLine();//9

            nombreTest = double.TryParse(nombre, out nombreConvertie);//9

            for (diviseur = 2; diviseur < nombreConvertie ; diviseur++)
            {
                testA = (nombreConvertie % diviseur);
                Console.WriteLine(testA);
                if (testA == 0)
                {
                     
                }


                Console.ReadLine();

            }
                
                /*
            if (nombreTest)
            {
                valeurRacine = Math.Sqrt(nombreConvertie);//3
                valeurRacineEntier = Convert.ToInt32(valeurRacine);//3
                
                for (diviseur = 2; diviseur < valeurRacineEntier; diviseur++)
                {
                    testA = (nombreConvertie / valeurRacineEntier);
                    Console.WriteLine(testA);
                    Console.ReadLine();
                }
            }
            else 
            {
                Console.WriteLine("probleme");
                Console.ReadLine();
            }
             */ 
        }
    }
}
