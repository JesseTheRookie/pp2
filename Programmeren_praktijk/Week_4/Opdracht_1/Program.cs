using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPdracht_1___
{
    class Program
    {
        static void Main(string[] args)
        {          
            int[,] matrix = new int[8, 8];
            Matrix.InitMatrixRandom(matrix, 1, 10);
            Matrix.PrintMatrixWithCross(matrix);
        
            Console.Write("Geef een getal op: ");
            int getal = int.Parse(Console.ReadLine());
            
            Matrix.Positie[,] pos = Matrix.Positie.ZoekGetal(matrix, getal);

            Matrix.PrintMatrixPositie(pos);        
            Console.ReadKey();
        }
    }
}
