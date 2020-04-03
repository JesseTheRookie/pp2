using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1__2__3
{
    class ChessLogic
    {
        public void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                for (int k = 0; k < chessboard.GetLength(1); k++)
                {
                    chessboard[r, k] = null;
                }
            }
            this.PutChessPieces(chessboard);
        }

        public void PlayChess(ChessPiece[,] chessboard)
        {
            InitChessboard(chessboard);
            string nietStop = "";

            while (nietStop != "stop")
            {
                DisplayChessboard(chessboard);

                Position from = ReadPosition("Enter from postition (e.g. A2): ");
                Position to = ReadPosition("Enter from postition (e.g. A3): ");

                CheckMove(chessboard, from, to);
            }
        }

        public Position ReadPosition(string question)
        {
            Console.Write(question);

            string enteredPosition = Console.ReadLine().ToUpper();
            int positionColumn = enteredPosition[0] - 'A';
            int positionRow = int.Parse(enteredPosition[1].ToString()) - 1;

            return new Position(positionRow, positionColumn);
        }

        public void DisplayChessboard(ChessPiece[,] chessboard)
        {
            Console.WriteLine("  A  B  C  D  E  F  G  H");

            for (int r = 0; r < chessboard.GetLength(0); r++)
            {
                Console.Write($"{r + 1}");

                for (int k = 0; k < chessboard.GetLength(1); k++)
                {
                    if ((r + k) % 2 != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                       

                    ChessPiece chessPiece = chessboard[r, k];

                    if(chessPiece == null)
                    {
                        Console.Write("   ");
                    }
                    else if(chessPiece.chessPieceColor == ChessPieceColor.white)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    if(chessPiece != null)
                    {
                        switch (chessPiece.chessPieceType)
                        {
                            case ChessPieceType.king:
                                Console.Write(" K ");
                                break;
                            case ChessPieceType.queen:
                                Console.Write(" Q ");
                                break;
                            case ChessPieceType.bishop:
                                Console.Write(" b ");
                                break;
                            case ChessPieceType.knight:
                                Console.Write(" k ");
                                break;
                            case ChessPieceType.rook:
                                Console.Write(" r ");
                                break;
                            case ChessPieceType.pawn:
                                Console.Write(" p ");
                                break;
                        }
                    }
                }

                Console.WriteLine();
                Console.ResetColor();
            }

        }

        public void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.rook, ChessPieceType.knight, ChessPieceType.bishop, ChessPieceType.king, ChessPieceType.queen, 
                                       ChessPieceType.bishop, ChessPieceType.knight, ChessPieceType.rook };

            for (int k = 0; k < chessboard.GetLength(1); k++)
            {
                chessboard[0, k] = new ChessPiece(order[k], ChessPieceColor.white);
                chessboard[1, k] = new ChessPiece(ChessPieceType.pawn, ChessPieceColor.white);

                chessboard[7, k] = new ChessPiece(order[k], ChessPieceColor.black);
                chessboard[6, k] = new ChessPiece(ChessPieceType.pawn, ChessPieceColor.black);
            }
        }
        public void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            ChessPiece chessPiece = chessboard[from.row, from.column];
            chessboard[to.row, to.column] = chessPiece;
            chessboard[from.row, from.column] = null;
        }
        public void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            ChessPiece chessPiece = chessboard[from.row, from.column];

            if(from != null && chessboard[to.row, to.column] == null && ValidMove(chessPiece, from, to))
            {
                DoMove(chessboard, from, to);
            }
            else
            {
                Console.WriteLine("invalid move");
            }
            Console.WriteLine();
        }
        public bool ValidMove(ChessPiece chessPiece, Position from, Position to)
        {
            switch (chessPiece.chessPieceType)
            {
                case ChessPieceType.king:
                    return ValidKingMove(from, to);
                case ChessPieceType.queen:
                    return ValidQueenMove(from, to);
                case ChessPieceType.bishop:
                    return ValidBishopMove(from, to);
                case ChessPieceType.knight:
                    return ValidKnightMove(from, to);
                case ChessPieceType.rook:
                    return ValidRookMove(from, to);
                case ChessPieceType.pawn:
                    return ValidPawnMove(from, to);
            }
            return false;
        }
        public bool ValidKingMove(Position from, Position to)
        {
            int x = Math.Abs(from.column - to.column);
            int y = Math.Abs(from.row - to.row);
            if (x + y == 1)
            {
                return true;
            }
            return false;
        }
        public bool ValidQueenMove(Position from, Position to)
        {
            int x = Math.Abs(from.column - to.column);
            int y = Math.Abs(from.row - to.row);
            if ((x * y == 0) || (x == y))
            {
                return true;
            }
            return false;
        }
        public bool ValidBishopMove(Position from, Position to)
        {
            int x = Math.Abs(from.column - to.column);
            int y = Math.Abs(from.row - to.row);
            if (x == y)
            {
                return true;
            }
            return false;
        }
        public bool ValidKnightMove(Position from, Position to)
        {
            int x = Math.Abs(from.column - to.column);
            int y = Math.Abs(from.row - to.row);
            if (x * y == 2)
            {
                return true;
            }
            return false;
        }
        public bool ValidRookMove(Position from, Position to)
        {
            int x = Math.Abs(from.column - to.column);
            int y = Math.Abs(from.row - to.row);
            if (x * y == 0)
            {
                return true;
            }
            return false;
        }
        public bool ValidPawnMove(Position from, Position to)
        {
            int x = Math.Abs(from.column - to.column);
            int y = Math.Abs(from.row - to.row);
            if ((x == 0) && (y == 1))
            {
                return true;
            }
            return false;
        }

    }
}
