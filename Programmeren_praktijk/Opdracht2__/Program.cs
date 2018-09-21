using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2__
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subject> rapport;

            Subject subjectName =  ReadSubject("Naam van het vak: ");
            int subjectGrade = ReadInt("Cijfer voor het vak: ", 1, 10);
        }

        static Rating ReadRating(string question)
        {

        }
        static void ShowRating(Rating question)
        {

        }
        //????? 
        static Subject ReadSubject(string question)
        {
            Console.WriteLine("Voer een vak in");
            string answer = (ReadString(question));

            return answer;        
        }
        static void ShowSubject(Subject subject)
        {
            
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
                Console.Write("Error");
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

