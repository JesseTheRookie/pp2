using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools_;

namespace MyToolsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = LeesTools.ReadInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt. ", number);

            int age = LeesTools.ReadInt("Hoe oud ben je? ", 0, 120);
            Console.WriteLine("Je bent {0} jaar oud. ", age);

            string name = LeesTools.ReadString("Hoe heet je? ");
            Console.WriteLine("Aangenaam om kennis met je te maken, {0}.", name);

            Console.ReadKey();
        }
    }
}
