using System;

namespace TestGalere
{
    // Définit un compte bancaire
public class CompteBancaire
{
    private string titulaire; // Titulaire du compte
    private double solde;     // Solde du compte
    private string devise;    // Devise du compte

    public string Titulaire
    {
        get { return titulaire; }
    }

    public double Solde
    {
        get { return solde; }
    }

    public string Devise
    {
        get { return devise; }
    }

    // Constructeur
    public CompteBancaire(string leTitulaire, double soldeInitial, string laDevise)
    {
        titulaire = leTitulaire;
        solde = soldeInitial;
        devise = laDevise;
    }

    // Ajoute un montant au compte
    public void Crediter(double montant)
    {
        solde = solde + montant;
    }

    // Retire un montant au compte
    public void Debiter(double montant)
    {
        solde = solde - montant;
    }

    // Renvoie la description du compte
    public string Decrire()
    {
        string description = "Le solde du compte de " + titulaire + " est de " + solde + " " + devise;
        return description;
    }
}
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
