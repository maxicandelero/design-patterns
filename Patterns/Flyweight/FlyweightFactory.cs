namespace design_patterns.Patterns.Flyweight
{
    // The Flyweight Factory creates and manages the Flyweight objects. It
    // ensures that flyweights are shared correctly. When the client requests a
    // flyweight, the factory either returns an existing instance or creates a
    // new one, if it doesn't exist yet.
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Shape[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.getKey(elem)));
            }
        }

        // Returns a Flyweight's string hash for a given state.
        private string getKey(Shape key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.ShapeType.ToString());
            elements.Add(key.Color);

            if (key.X.HasValue && key.Y.HasValue)
            {
                elements.Add(key.X.Value.ToString());
                elements.Add(key.Y.Value.ToString());
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Returns an existing Flyweight with a given state or creates a new
        // one.
        public Flyweight GetFlyweight(Shape sharedState)
        {
            string key = this.getKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault()!.Item1;
        }

        public string FlyweightsCount()
        {
            return $"FlyweightFactory: I have { flyweights.Count } flyweights.";
        }
    }
}