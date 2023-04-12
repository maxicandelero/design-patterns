namespace design_patterns.Patterns.Prototype
{
    public class Chessboard : ICloneable
    {
        public string? Opponent1 { get; set; }
        public string? Opponent2 { get; set; }
        public IEnumerable<ChessPiece>? ChessPieces;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}