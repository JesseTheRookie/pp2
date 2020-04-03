using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerLogic playerLogic = new PlayerLogic();
            playerLogic.Start();

            Console.ReadKey();
        }
       
    }
}
