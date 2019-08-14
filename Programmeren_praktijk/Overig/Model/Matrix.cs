using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Matrix
    {
        public static void InitMatrix2d(int[,] matrix)
        {
            int i = 1;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for(int k = 0; k < matrix.GetLength(1); k++)
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
        public static void InitMatrixLineair(int[,] matrix)
        {
            //Kwam hier niet uit
        }
        public static void PrintMatrixWithCross(int[,] matrix)
        {

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {                    
                    if(r == k)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0,3} ", matrix[r, k]);
                }
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
            public static Positie ZoekGetal(int[,] matrix, int zoekGetal)
            {
                Positie pos = new Positie()
                {
                    rij = 0,
                    kolom = 0
                };

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        if (r == zoekGetal)
                        {
                            pos.rij = r;
                        }
                        if (k == zoekGetal)
                        {
                            pos.kolom = k;
                        }
                    }
                }
                return pos;
            }
        }
    }
}
