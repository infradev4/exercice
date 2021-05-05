using System;

namespace Exercice_1._10B
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            VARIABLES
            saisie est un entier
            N est un entier 
            I est un entier
            nombreCourant est un entier
            sommeDiviseurs est un entier
            nombresParfaitsTrouves est un entier 
            
            DEBUT
            écrire "Combien de nombres parfaits souhaitez vous afficher"
            lire saisie
            
            POUR N de 0 à (saisie-1)
                REPETER 
                    nombreCourant++ // egal à 1 (1er passage)
                    POUR I de 1 à nombreCourant
                        SI nombreCourant % I EST EGAL à 0
                            sommeDiviseurs <-- sommediviseurs + I
                        FIN SI
                    FIN POUR
                    SI nombreCourant EST EGAL à sommeDiviseurs
                        ecrire , nombreCourant, est un nombre parfait
                        nombresParfaitsTrouves++
                    FIN SI
                TANT QUE nombreParfaitsTrouves EST INFERIEUR A saisie
                FIN REPETER
                
            FIN POUR
            FIN
        */
        string a;
        int saisie;
        int n; 
        int I;
        int nombreCourant = 1;
        int sommeDiviseurs;
        int nombresParfaitsTrouves; 

        Console.WriteLine("Programme de recherche des nombres parfaits");
        Console.WriteLine("Combien de nombre parfaits souhaitez-vous afficher ? :");

        a = Console.ReadLine();
        saisie = int.Parse(a); 

        for(n = 1; n < saisie; n++)
        {
            do 
            {
            nombreCourant++;

                for(I = 1; I < nombreCourant ; nombreCourant++)
                {
                    if(nombreCourant % I == 0)
                    {
                       sommeDiviseurs = (nombreCourant % I);
                    }
                }
                
                if(nombreCourant == sommeDiviseurs)
                {
                    Console.WriteLine("Affichage des " + saisie + " premiers nombres parfaits :");
                    Console.WriteLine(" " + nombreCourant + " , est un nombre parfait");
                    nombresParfaitsTrouves++;
                }
            }
            while(nombresParfaitsTrouves<saisie);
            Console.ReadLine();

        }
        
    }
}
}
