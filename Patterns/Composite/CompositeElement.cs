using System.Text;

namespace design_patterns.Patterns.Composite
{
    // The Composite class represents the complex components that may have
    // children. Usually, the Composite objects delegate the actual work to
    // their children and then "sum-up" the result.
    public class CompositeElement : DrawingElement
    {
        protected List<DrawingElement> _elements = new List<DrawingElement>();

        public CompositeElement(string name)
        {
            this._name = name;
        }

        // A composite object can add or remove other components
        // (both simple or complex) to or from its child list.
        public override void Add(DrawingElement element)
        {
            _elements.Add(element);
        }
        public override void Remove(DrawingElement element)
        {
            _elements.Remove(element);
        }

        // The Composite executes its primary logic in a particular way. It
        // traverses recursively through all its children, collecting and
        // summing their results. Since the composite's children pass these
        // calls to their children and so forth, the whole object tree is
        // traversed as a result.
        public override string Display(int indent)
        {
            StringBuilder result = new StringBuilder();
            result.Append($" { new String('-', indent) }{ this._name }");
             

            foreach (DrawingElement element in _elements)
            {
                result.Append(element.Display(indent + 2));
            }

            return result.ToString();
        }
    }
}