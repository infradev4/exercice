using System;

namespace TestGalere
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = 5;
            Console.WriteLine("Avant l'appel, nombre = " + nombre);
            Augmenter(nombre);
            Console.WriteLine("Après l'appel, nombre = " + nombre);
        }
        static void Augmenter(int unPombre)
        {
            Console.WriteLine("Avant l'augmentation, unNombre = " + unPombre);
            unPombre = unPombre + 1;
            Console.WriteLine("Après l'augmentation, unNombre = " + unPombre);
        }
    }
}
