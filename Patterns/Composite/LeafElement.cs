namespace design_patterns.Patterns.Composite
{
    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.
    public class LeafElement : DrawingElement
    {
        public LeafElement(string name)
        {
            this._name = name;
        }

        public override string Display(int indent)
        {
            return $" { new String('-', indent) }{ this._name }";
        }
    }
}