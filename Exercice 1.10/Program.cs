using System;
using System.Collections.Generic;//pour utiliser les listes


namespace Exercice_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreEntrer;
            int nombreConverti;
            bool nombreTeste;
            int index;
            //int TotalA;
            int totalParfait;

            //System.Collections.Generic = utiliser pour les utiliser les listes
            List<string> liste = new List<string>() {"a",b};

            ou

            List.Add("aaa");
            List.Add("bbb");
            liste[1] = "ccc"

            Console.WriteLine(liste.Count);



            Console.WriteLine("Programme de calcul des Nombres parfaits");
            Console.WriteLine("Entrer un nombre entier :");
            nombreEntrer = Console.ReadLine();

            nombreTeste = int.TryParse(nombreEntrer,out nombreConverti);

            if (nombreTeste)
            {
                for (index = 1; nombreConverti >= index; index++)
                {
                    totalParfait = (nombreConverti / index);
                    Console.WriteLine("nombreConverti: " + nombreConverti + " index: " + index);
                    Console.WriteLine("totalParfait " + totalParfait);
                    if (totalParfait == 0)
                    { }
                }
            }
        Console.ReadLine();

            List<int> liste = new List<int>() {"a",b};

        }
    }
}
