namespace design_patterns.Patterns.Flyweight
{
    public class Shape
    {
        public ShapeType ShapeType { get; set; }
        public string Color { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
    }

    public enum ShapeType
    {
        Circle,
        Square,
        Rectangle,
        Triangle
    }
}