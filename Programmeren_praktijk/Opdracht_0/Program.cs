using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt. ", number);

            int age = ReadInt("Hoe oud ben je? ", 0, 120);
            Console.WriteLine("Je bent {0} jaar oud. ", age);

            string name = ReadString("Hoe heet je? ");
            Console.WriteLine("Aangenaam om kennis met je te maken, {0}.", name);

            Console.ReadKey();
        }
        static int ReadInt(string question)
        {
            Console.Write(question);
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        static int ReadInt(string question, int min, int max)
        {
            int answer = ReadInt(question);
            if (answer < min || answer > max)
            {
                Console.Write("Voer opnieuw een getal in, tussen 0 en 120: ");
                answer = ReadInt(question);
            }
            return answer;
        }
        static string ReadString(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
