using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        public enum GenderType
        {
            male, female
        }

        struct Person
        {
            public string Lastname, Residence, Firstname;
            public int Age;
            public GenderType Gender;
        }

        static void Main(string[] args)
        {
            Person[] personArray = new Person[3];
            for (int i = 0; i < personArray.Length; i++)
            {
                personArray[i] = ReadPerson();
            }

            for (int i = 0; i < personArray.Length; i++)
            {
                PrintPerson(personArray[i]);
            }

            CelebrateBirthday(ref personArray[0]);

            Console.ReadKey();
        }
        static int ReadInt(string question)
        {
            Console.Write(question);
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        static string ReadString(string question)
        {
            Console.Write(question);
            string answer = Console.ReadLine();
            return answer;
        }
        static GenderType ReadGender(string question)
        {
            string answer = ReadString(question);
            GenderType value = GenderType.female;
            answer.ToLower();

            if (answer == "m")
            {
                value = GenderType.male;
            }

            return value;
        }
        static void CelebrateBirthday(ref Person p)
        {
            p.Age++;
            Console.WriteLine("Celebrate birthday of " + p.Firstname + " " + p.Lastname);
            PrintPerson(p);
        }
        static void PrintGender(GenderType gender)
        {
            Console.Write(gender);
        }
        static Person ReadPerson()
        {
            Person person;

            person.Firstname = ReadString("Type first name: ");
            person.Lastname = ReadString("Type last name: ");
            person.Age = ReadInt("Type age: ");
            person.Residence = ReadString("Type residence: ");
            person.Gender = ReadGender("Type gender (m/v): ");

            Console.WriteLine();

            return person;
        }
        static void PrintPerson(Person p)
        {
            Console.Write(p.Firstname + " " + p.Lastname);

            if (p.Gender == GenderType.male)
            {
                Console.Write(" (m)");
            }
            else
            {
                Console.Write(" (v)");
            }

            Console.WriteLine();
            Console.WriteLine(p.Age + " jaar, " + p.Residence);
            Console.WriteLine();
        }
    }
}