using System.Text.Json;

namespace design_patterns.Patterns.Flyweight
{
    // The Flyweight stores a common portion of the state (also called intrinsic
    // state) that belongs to multiple real business entities. The Flyweight
    // accepts the rest of the state (extrinsic state, unique for each entity)
    // via its method parameters.
    public class Flyweight
    {
        private Shape _sharedState;

        public Flyweight(Shape shape)
        {
            this._sharedState = shape;
        }

        public string Operation(Shape uniqueState)
        {
            string s = JsonSerializer.Serialize(this._sharedState);
            string u = JsonSerializer.Serialize(uniqueState);
            return $"Flyweight: Displaying shared {s} and unique {u} state.";
        }
    }
}