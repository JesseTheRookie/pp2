using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1__2__3
{
    class ChessPiece
    {
        public ChessPieceColor chessPieceColor;
        public ChessPieceType chessPieceType;

        public ChessPiece(ChessPieceType type, ChessPieceColor color)
        {
            this.chessPieceColor = color;
            this.chessPieceType = type;
        }
    }
}
