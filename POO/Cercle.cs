using System;

namespace POO
{
    public class Cercle
    {
        private double rayon; // rayon du cercle
        public double Rayon
        {
        get { return rayon; }
        set { rayon = value; }
        }

        // constructeur
        public Cercle(double rayon)
        {
        this.rayon = rayon;
        }
        
        // calcule le périmètre du cercle
        public double CalculerPerimetre()
        {
        double perimetre = 2 * Math.PI * rayon;
        return perimetre;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        //Creation de de l'objet monCercle de la class Cercle
        Cercle monCercle = new Cercle(7.5);

        int nombre1 = 5;
        int nombre2 = 3;
        nombre2 = nombre1;
        nombre1 = 10;

        Console.WriteLine("nombre1 = " + nombre1);
        Console.WriteLine("nombre2 = " + nombre2);

        Cercle cercle1 = new Cercle(5); // déclaration et instanciation
        Cercle cercle2 = new Cercle(3); // déclaration et instanciation

        cercle2 = cercle1;
        cercle1.Rayon = 10;

        Console.WriteLine("cercle1.Rayon = " + cercle1.Rayon);
        Console.WriteLine("cercle2.Rayon = " + cercle2.Rayon);




        }

    }
}
