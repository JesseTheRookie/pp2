using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[11, 11];
            InitMatrixRandom(matrix, 1, 10);
            PrintMatrixWithCross(matrix);

            Console.Write("Geef een getal op: ");
            int getal = int.Parse(Console.ReadLine());

            Positie[,] pos = ZoekGetal(matrix, getal);

            PrintMatrixPositie(pos);
            Console.ReadKey();
        }
        public static void InitMatrix2d(int[,] matrix)
        {
            int i = 1;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[r, k] += i;
                    i++;
                }
            }
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0,3} ", matrix[r, k]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        public static void PrintMatrixPositie(Positie[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0,3} ", matrix[r, k]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        public static void InitMatrixLineair(int[,] matrix)
        {
            //Kwam hier niet uit
        }
        public static void PrintMatrixWithCross(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (i == k)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if ((i + k) == (matrix.GetLength(0) - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }


                    Console.Write("{0,3} ", matrix[i, k]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        public static void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[r, k] = rnd.Next(min, max);
                }
            }
        }
        public struct Positie
        {
            public int rij;
            public int kolom;
        }

        public static Positie[,] ZoekGetal(int[,] matrix, int zoekGetal)
        {
            Positie pos = new Positie()
            {
                rij = 0,
                kolom = 0
            };
            Positie[,] posities = new Positie[2, 10];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    while (matrix[r, k] == zoekGetal)
                    {
                        pos.rij = r;
                        pos.kolom = k;
                        posities[r, k] = pos;
                    }
                }
            }
            return posities;
        }
    }
}
