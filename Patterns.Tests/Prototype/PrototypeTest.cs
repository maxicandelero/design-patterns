using design_patterns.Patterns.Prototype;
using Xunit;

namespace design_patterns.Patterns.Tests.Prototype
{
    public class PrototypeTest
    {
        [Fact]
        public void generate_a_new_chessboard_shallow_copy()
        {   
            var chessboard = new Chessboard();
            chessboard.Opponent1 = "John Doe";
            chessboard.Opponent2 = "The Opponent";
            chessboard.ChessPieces = new List<ChessPiece>() 
            { 
                new ChessPiece() { Type = ChessPieceType.Pawn, Amount = 5 },
                new ChessPiece() { Type = ChessPieceType.Knight, Amount = 1 },
                new ChessPiece() { Type = ChessPieceType.Rook, Amount = 1 },
                new ChessPiece() { Type = ChessPieceType.Queen, Amount = 1 },
                new ChessPiece() { Type = ChessPieceType.King, Amount = 1 },
            };

            Chessboard copy = (Chessboard)chessboard.Clone();

            Assert.NotSame(chessboard, copy); // The two objects are different instances
            Assert.Equal(chessboard.Opponent1, copy.Opponent1);
            Assert.Equal(chessboard.Opponent2, copy.Opponent2);
            Assert.Equal(chessboard.ChessPieces, copy.ChessPieces);
        }
    }
}