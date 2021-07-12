using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        /*
        somme(1, 2) ➞ 3
        somme(100, 200) ➞ 300
        somme(-3, -2) ➞ -5
        */
        
        public static int somme(int saisieConvertie_a, int saisieConvertie_b)
        {
            return saisieConvertie_a + saisieConvertie_b;
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("Veuillez saisir 2 nombres séparés par un espace : ");

            string saisieUsers = Console.ReadLine();
            string[] substituer = saisieUsers.Split(' ');

            string saisie_a = substituer[0];
            string saisie_b = substituer[1];

            string saisie_a_Ok = int.TryParse(saisie_a, out saisieConvertie_a);
            string saisie_b_Ok = int.TryParse(saisie_b, out saisieConvertie_b);
            


        }
    }
}
