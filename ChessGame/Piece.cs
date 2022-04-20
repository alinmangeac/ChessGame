using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    public enum PieceType
    {
        PAWN,
        BISHOP,
        KNIGHT,
        ROOK,
        QUEEN,
        KING
    };
    interface IPiece
    {
        bool IsWhite { get; set; }
        void GetPiece();
        Position Location { get; set; }
        PieceType Type { get; set; }
    }

    internal class Pawn : IPiece
    {
        public Position Location { get; set; }
        public PieceType Type
        {
            get
            {
                return PieceType.PAWN;
            }

            set
            {
                Type = value;
            }
        }

        public bool IsWhite { get; set; }

        public void GetPiece()
        {
            throw new NotImplementedException();
        }
    }
    internal class Bishop : IPiece
    {
        public Position Location { get; set; }
        public PieceType Type
        {
            get
            {
                return PieceType.BISHOP;
            }

            set
            {
                Type = value;
            }
        }

        public bool IsWhite { get; set; }

        public void GetPiece()
        {
            throw new NotImplementedException();
        }
    }
    internal class Knight : IPiece
    {
        public Position Location { get; set; }
        public PieceType Type
        {
            get
            {
                return PieceType.KNIGHT;
            }

            set
            {
                Type = value;
            }
        }

        public bool IsWhite { get; set; }

        public void GetPiece()
        {
            throw new NotImplementedException();
        }
    }
    internal class Rook : IPiece
    {
        public Position Location { get; set; }
        public PieceType Type
        {
            get
            {
                return PieceType.ROOK;
            }

            set
            {
                Type = value;
            }
        }

        public bool IsWhite { get; set; }

        public void GetPiece()
        {
            throw new NotImplementedException();
        }
    }
    internal class Queen : IPiece
    {
        public Position Location { get; set; }
        public PieceType Type
        {
            get
            {
                return PieceType.QUEEN;
            }

            set
            {
                //value is C# object and represents the assigned value (right side of =)
                Type = value;
            }
        }
        public bool IsWhite { get; set; }

        public void GetPiece()
        {
        }
    }

    internal class King : IPiece
    {
        public Position Location { get; set; }
        public PieceType Type
        {
            get
            {
                return PieceType.KING;
            }

            set
            {
                Type = value;
            }
        }

        public bool IsWhite { get; set; }

        public void GetPiece()
        {
            throw new NotImplementedException();
        }
    }

    class test
    {
        IPiece piece;

        void Set(IPiece piece)
        {
            this.piece = piece;
            piece.Type = PieceType.PAWN;
            this.piece.Type = piece.Type;
        }
    }

}
