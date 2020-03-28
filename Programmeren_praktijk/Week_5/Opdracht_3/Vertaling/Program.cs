using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertaling
{
    class Program
    {
        static void Main(string[] args)
        {
            TranslateWords(ReadWords("dictionary.csv"));
            Console.ReadKey();
        }
        static Dictionary<string, string> ReadWords(string filename)
        {
            string line;
            Dictionary<string, string> translations = new Dictionary<string, string>();

            StreamReader reader = new StreamReader(filename);

            while ((line = reader.ReadLine()) != null)
            {
                string[] splitTranslation = line.Split(';');
                translations.Add(splitTranslation[0], splitTranslation[1]);
            }

            return translations;
        }
        static void TranslateWords(Dictionary<string, string> words)
        {
            string enteredWord = "";

            while (enteredWord != "stop")
            {
                Console.Write("enter a word: ");
                enteredWord = Console.ReadLine();

                if (enteredWord == "listall")
                {
                    ListAllWords(words);
                }
                if (!words.ContainsKey(enteredWord))
                {
                Console.WriteLine("Word is not in dictionary");
                }
                else
                {
                    Console.WriteLine($"{enteredWord} => {words[enteredWord]}");
                }
            }
             Console.WriteLine("program has stopped");
        }
        static void ListAllWords(Dictionary<string, string> words)
        {
            foreach(KeyValuePair<string, string> word in words)
            {
                Console.WriteLine($"{word.Key} => {word.Value}");
            }
        }
    }
}
