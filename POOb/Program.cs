using System;

namespace POOb
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 5;
            Console.WriteLine("Avant l'appel, nombre = " + nombre);
            //Augmenter(ref nombre);
            Augmenter(nombre);
            Console.WriteLine("Après l'appel, nombre = " + nombre);
        }
        //static void Augmenter(ref int unNombre)
        static void Augmenter(int unNombre)
        {
            Console.WriteLine("Avant l'augmentation, unNombre = " + unNombre);
            unNombre = unNombre + 1;
            Console.WriteLine("Après l'augmentation, unNombre = " + unNombre);

            /*
            Avant l'appel, nombre = 5
            Avant l'augmentation, unNombre = 5
            Après l'augmentation, unNombre = 6
            Après l'appel, nombre = 5
            */
        }
    }
}
