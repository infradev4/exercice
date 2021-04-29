using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie_a;
            int saisieConvertie_a;
            string saisie_b;
            int saisieConvertie_b;       
            float total;
            bool saisie_a_Ok;
            bool saisie_b_Ok;
            string continuer_oui;

            Console.WriteLine("Programme de calcul de la moyenne de 2 nombres.");

            do
            {
                Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace :");
                                
                saisie_a = Console.ReadLine();
                saisie_b = Console.ReadLine();
                saisie_a_Ok = int.TryParse(saisie_a, out saisieConvertie_a);
                saisie_b_Ok = int.TryParse(saisie_b, out saisieConvertie_b);

                if(saisie_a_Ok && saisie_b_Ok) {

                    total = ((saisieConvertie_a + saisieConvertie_b) / 2);

                    Console.WriteLine("La moyenne de " + saisie_a + " et "+saisie_b + " est de " + total);
                }
                
                else {
                    Console.WriteLine("Erreur de saisie");
                }

                Console.WriteLine("Souhaitez-vous faire un autre calcul ? (O/N)");
                continuer_oui = Console.ReadLine();
            }
            
            while(continuer_oui.ToLower() == "o" );
            
           
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadLine();
        }
    }
}
