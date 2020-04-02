using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1__2__3
{
    class Position
    {
        public int row;
        public int column;

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public Position ReadPosition(string question)
        {
            Console.Write(question);

            string enteredPosition = Console.ReadLine().ToLower();
            int positionColumn = enteredPosition[0] - 'A';
            int positionRow = int.Parse(enteredPosition[1].ToString()) - 1;

            return new Position(positionRow, positionColumn);
        }

    }
}
