using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    struct YahtzeeGame
    {
        public Dice[] dice;
        public void Throw()
        {
            for (int i = 0; i < 5; i++)
            {
                //   Dice d;
                // d.value = 0;
                // d.Throw();
                dice[i].Throw();
            }
        }
        public void ShowValue()
        {

            foreach (Dice d in dice)
            {

                Console.Write(" " + d.value);
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                if (dice[i].value == dice[0].value)
                    count++;
            }

            return count == 5;
        }
        public bool ThreeOfAKind()
        {
            bool sum = false;

            for (int i = 0; i <= 6; i++)
            {
                int count = 0;
                for (int x = 0; x < 5; x++)
                {
                    if (dice[x].value == i)
                        count++;

                    if (count == 3)
                        sum = true;
                }
            }

            return sum;
        }
        public bool FourOfAKind()
        {
            bool sum = false;

            for (int i = 0; i <= 6; i++)
            {
                int count = 0;
                for (int x = 0; x < 5; x++)
                {
                    if (dice[x].value == i)
                        count++;

                    if (count == 4)
                        sum = true;
                }
            }

            return sum;
        }
    }
}
