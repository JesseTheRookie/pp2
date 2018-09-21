using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
        struct Dice
        {
            public int value;
            static Random rnd = new Random();
            public void Throw()
            {
                value = rnd.Next(1, 7);
            }
            public void ShowValue()
            {
                Console.Write(" " + value);
            }
        }
}
