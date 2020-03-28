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
            PrintMatrix(matrix);

            Console.Write("Geef een getal op: ");
            int getal = int.Parse(Console.ReadLine());

            Positie positie = ZoekGetalAchterwaarts(matrix, getal);

            PrintMatrixPositie(positie, getal);
            Console.ReadKey();
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
        public static void PrintMatrixPositie(Positie positie, int zoekgetal)
        {
            Console.WriteLine($"Zoekgetal {zoekgetal} komt het eerst voor op positie [{positie.rij}, {positie.kolom}]", zoekgetal, positie.rij, positie.kolom);
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
        public class Positie
        {
            public int rij;
            public int kolom;
        }
        public static Positie ZoekGetal(int[,] matrix, int zoekGetal)
        {
            Positie positie = new Positie();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[r, k] == zoekGetal)
                    {
                        positie.rij = r;
                        positie.kolom = k;
                        return positie;
                    }
                }
            }
            return positie;
        }
        public static Positie ZoekGetalAchterwaarts(int[,] matrix, int zoekGetal)
        {
            Positie positie = new Positie();

            for (int r = matrix.GetLength(0); r --> 0;)
            {
                for (int k = matrix.GetLength(1); k --> 0;)
                {
                    if (matrix[r, k] == zoekGetal)
                    {
                        Console.WriteLine(matrix[r, k]);
                        positie.rij = r;
                        positie.kolom = k;
                        return positie;
                    }
                }
            }
            return positie;
        }
    }
}
