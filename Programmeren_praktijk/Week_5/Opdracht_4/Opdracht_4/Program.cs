using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            LingoPlayerLogic lingoPlayerLogic = new LingoPlayerLogic();
            lingoPlayerLogic.Start();
            Console.ReadKey();
        }

    }
}
