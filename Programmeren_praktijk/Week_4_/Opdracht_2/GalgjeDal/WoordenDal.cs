using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalgjeDal
{
    public class WoordenDal
    {
        public List<string> GetAll()
        {
            List<string> words = new List<string>();
            string line;
            StreamReader reader = new StreamReader("woorden.txt");

            while ((line = reader.ReadLine()) != null)
            {
                if(line.Length >= 3)
                {
                    words.Add(line);
                }
            }

            return words;
        }
    }
}
