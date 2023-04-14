using design_patterns.Patterns.Composite;
using Xunit;

namespace design_patterns.Patterns.Tests.Composite
{
    public class CompositeTest
    {
        [Fact]
        public void generate_a_new_graphical_tree_structure()
        {   
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new LeafElement("Red Line"));
            root.Add(new LeafElement("Blue Circle"));
            root.Add(new LeafElement("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new LeafElement("Black Circle"));
            comp.Add(new LeafElement("White Circle"));
            root.Add(comp);

            string result = root.Display(1);

            Assert.Equal(@" -Picture ---Red Line ---Blue Circle ---Green Box ---Two Circles -----Black Circle -----White Circle", result);
        }

        [Fact]
        public void add_a_new_leaf_element_to_graphical_tree_structure()
        {   
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new LeafElement("Red Line"));
            root.Add(new LeafElement("Blue Circle"));
            root.Add(new LeafElement("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new LeafElement("Black Circle"));
            comp.Add(new LeafElement("White Circle"));
            root.Add(comp);

            // Add  a PrimitiveElement
            LeafElement pe = new LeafElement("Yellow Line");
            root.Add(pe);
            
            string result = root.Display(1);

            Assert.Equal(@" -Picture ---Red Line ---Blue Circle ---Green Box ---Two Circles -----Black Circle -----White Circle ---Yellow Line", result);
        }

        [Fact]
        public void remove_a_new_leaf_element_to_graphical_tree_structure()
        {   
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new LeafElement("Red Line"));
            root.Add(new LeafElement("Blue Circle"));
            root.Add(new LeafElement("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circles");
            var leaf = new LeafElement("Black Circle");
            comp.Add(leaf);
            comp.Add(new LeafElement("White Circle"));
            root.Add(comp);

            // Remove a PrimitiveElement
            comp.Remove(leaf);

            string result = root.Display(1);

            Assert.Equal(@" -Picture ---Red Line ---Blue Circle ---Green Box ---Two Circles -----White Circle", result);
        }
    }
}