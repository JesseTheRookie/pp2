using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LingoLogic;

namespace LingoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLogic logic = new GameLogic();
            logic.Start();
            Console.ReadKey();
        }
    }
}
