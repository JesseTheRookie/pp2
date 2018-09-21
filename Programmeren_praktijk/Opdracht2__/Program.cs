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
            List<Subject> rapport = new List<Subject>();
            FillList(rapport);
        }
        static void FillList(List<Subject> intake)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Voer een vak in. ");
                string subjectName = ReadString("Naam van het vak: ");
                int theoryGrade = ReadInt("Cijfer voor " + subjectName + ": ", 10, 100);
                int counter = 0;
                foreach (string name in Enum.GetNames(typeof(Rating)))
                {
                    Console.Write(counter + ". " + name + ", ");
                    counter++;
                }
                Console.WriteLine();
                Rating rating = ReadRating("Practicum beoordeling voor " + subjectName + ": ");
                Console.WriteLine();

                Subject x;

                x.subjectName = subjectName;
                x.theoryGrade = theoryGrade;
                x.practicum = rating;

                intake.Add(x);
            }
        }
        static Rating ReadRating(string question)
        {
            Console.Write(question);
            int x = int.Parse(Console.ReadLine());
            Rating answer = (Rating)x;
            return answer;
        }
        static void ShowRating(Rating judgement)
        {

        }
/*
        static Subject ReadSubject(string question)
        {
            Console.WriteLine(question);

            Subject Con;
            x.subjectName = question;

            return x;        
        }
*/
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

