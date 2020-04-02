using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1__2__3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPiece[,] chessPieces = new ChessPiece[8, 8];
            ChessLogic chessLogic = new ChessLogic();

            chessLogic.InitChessboard(chessPieces);
            chessLogic.DisplayChessboard(chessPieces);

            Console.ReadKey();
        }

    }
}
