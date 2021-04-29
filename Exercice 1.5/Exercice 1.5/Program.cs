using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string placement;
            double placementConvertie;
            bool placementTeste;

            double interetSimple;
            double interetCompose;
            
            string nombreAnnees;
            double nombreAnneesConvertie;
            bool nombreAnneesTeste;
            
            string interet;
            double interetConvertie;
            bool interetTeste;

            double total;
            double totalB;

            Console.WriteLine("Calcul d’intérêts");
            Console.WriteLine("indiquez le montant de votre placement de départ :");
            placement = Console.ReadLine();
                        
            placementTeste = double.TryParse(placement, out placementConvertie);

            Console.WriteLine("indiquez la durée du placement en années :");
            nombreAnnees = Console.ReadLine();
            
            nombreAnneesTeste = double.TryParse(nombreAnnees,out nombreAnneesConvertie);

            Console.WriteLine("indiquez le Taux annuel de rendement espéré:");
            interet = Console.ReadLine();

            interetTeste = double.TryParse(interet, out interetConvertie);
                        
            if (placementTeste && nombreAnneesTeste && interetTeste)
            {
                interetSimple = (placementConvertie *(1 + ((nombreAnneesConvertie/100) * interetConvertie)));
                interetCompose = (placementConvertie * Math.Pow(1 + interetConvertie, nombreAnneesConvertie));

                total = (interetSimple - placementConvertie);
                totalB = (total - interetCompose);

                Console.WriteLine("la valeur acquise par votre placement de " + placementConvertie + " placée pendant " + nombreAnneesConvertie + " années est de : " + interetSimple + " les intérêts générés par le placement ont produit ");
                //Console.WriteLine(+totalB + "€ euros d’intérêts supplémentaires grâce aux intérêts capitalisés depuis " + nombreAnneesConvertie);
                
                Console.WriteLine("Le montant des interets sont de : " + total);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Erreur de saisie. Veuillez entrer des chiffres ");
                Console.ReadLine();
            }


        }
    }
}
