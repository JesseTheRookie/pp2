using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            PrintMonths();
            Month month = AskMonth("Write down a month (number): ");
            PrintMonth(month);

            Console.ReadKey();
        }

        static void PrintMonth(Month month)
        {
            int counter = 0;
            for (Month i = Month.Januari; i <= month; i++)
            {
                counter++;
            }

            Console.WriteLine(counter + ". " + month);
        }

        static void PrintMonths()
        {
            for (Month i = Month.Januari; i <= Month.December; i++)
                PrintMonth(i);
        }

        static Month AskMonth(string question)
        {
            Console.Write(question);
            Month month = (Month)int.Parse(Console.ReadLine());

            while (!Enum.IsDefined(typeof(Month), month))
            {
                Console.WriteLine(month + " is not an acceptable value");
                Console.Write("Enter new month number: ");
                month = (Month)int.Parse(Console.ReadLine());
            }

            return month;
        }

    }
}
