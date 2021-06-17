using ClassLibraryVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture MercedesBenz;
            MercedesBenz = new Voiture();
            //MercedesBenz.Demarrer();

            Voiture deuxiemeMercedesBenz = new Voiture(MercedesBenz);

            Console.ReadKey();
        }
    }
}
