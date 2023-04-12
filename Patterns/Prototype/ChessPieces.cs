namespace design_patterns.Patterns.Prototype
{
    public class ChessPiece
    {
        public ChessPieceType Type { get; set; }
        public ushort Amount { get; set; }
    }

    public enum ChessPieceType
    {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }
}