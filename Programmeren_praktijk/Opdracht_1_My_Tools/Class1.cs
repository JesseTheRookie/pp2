using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1_My_Tools
{
    struct LeesTools
    {
        public static int ReadInt(string question)
        {
            Console.Write(question);
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        public static int ReadInt(string question, int min, int max)
        {
            int answer = ReadInt(question);
            if (answer < min || answer > max)
            {
                Console.Write("Voer opnieuw een getal in, tussen 0 en 120: ");
                answer = ReadInt(question);
            }
            return answer;
        }
        public static string ReadString(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();
            return answer;
        }
    }
}
