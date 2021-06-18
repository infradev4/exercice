using ClassLibraryCompteBancaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte1 = new CompteBancaire("oz", 10, "euros");
            Console.WriteLine(compte1.Decrire());

            CompteBancaire compte2 = new CompteBancaire("bob", 100, "mad");
            Console.WriteLine(compte2.ToString());
            Console.WriteLine(compte2);



            Console.ReadKey();
        }
    }
}
