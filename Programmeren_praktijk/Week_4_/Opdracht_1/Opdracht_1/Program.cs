using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace Opdracht1___
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p = new Persoon();
            Console.Write("Wat is uw naam? ");
            p.LeesPersoon(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
