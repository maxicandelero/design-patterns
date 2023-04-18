using System.Text.Json;
using design_patterns.Patterns.Flyweight;
using Xunit;

namespace design_patterns.Patterns.Tests.Flyweight
{
    public class FlyweightTest
    {
        [Fact]
        public void flyweight_factory_should_share_an_existing_object()
        {   
            var flyweightFactory = new FlyweightFactory(
                new Shape { ShapeType = ShapeType.Circle, Color = "Red" },
                new Shape { ShapeType = ShapeType.Circle, Color = "Green" },
                new Shape { ShapeType = ShapeType.Circle, Color = "Blue" },
                new Shape { ShapeType = ShapeType.Rectangle, Color = "Red" },
                new Shape { ShapeType = ShapeType.Rectangle, Color = "Green" },
                new Shape { ShapeType = ShapeType.Rectangle, Color = "Blue" }
            );

            var newCircle = new Shape { ShapeType = ShapeType.Rectangle, Color = "Green", X = 10, Y = 20 };
            var flyweightShape = flyweightFactory.GetFlyweight(new Shape { ShapeType = newCircle.ShapeType, Color = newCircle.Color });

            Assert.Equal("FlyweightFactory: I have 6 flyweights.", flyweightFactory.FlyweightsCount());
            Assert.Equal($"Flyweight: Displaying shared { JsonSerializer.Serialize(new Shape { ShapeType = ShapeType.Rectangle, Color = "Green"}) } and unique " + 
                $"{ JsonSerializer.Serialize(new Shape { ShapeType = ShapeType.Rectangle, Color = "Green", X = 10, Y = 20 }) } state.", 
                flyweightShape.Operation(newCircle));
        }

        [Fact]
        public void flyweight_factory_should_add_a_new_object_and_share_it()
        {   
            var flyweightFactory = new FlyweightFactory(
                new Shape { ShapeType = ShapeType.Circle, Color = "Red" },
                new Shape { ShapeType = ShapeType.Circle, Color = "Green" },
                new Shape { ShapeType = ShapeType.Circle, Color = "Blue" },
                new Shape { ShapeType = ShapeType.Rectangle, Color = "Red" },
                new Shape { ShapeType = ShapeType.Rectangle, Color = "Green" },
                new Shape { ShapeType = ShapeType.Rectangle, Color = "Blue" }
            );

            var newCircle = new Shape { ShapeType = ShapeType.Triangle, Color = "Blue", X = 10, Y = 20 };
            var flyweightShape = flyweightFactory.GetFlyweight(new Shape { ShapeType = newCircle.ShapeType, Color = newCircle.Color });

            Assert.Equal("FlyweightFactory: I have 7 flyweights.", flyweightFactory.FlyweightsCount());
            Assert.Equal($"Flyweight: Displaying shared { JsonSerializer.Serialize(new Shape { ShapeType = ShapeType.Triangle, Color = "Blue"}) } and unique " + 
                $"{ JsonSerializer.Serialize(new Shape { ShapeType = ShapeType.Triangle, Color = "Blue", X = 10, Y = 20 }) } state.", 
                flyweightShape.Operation(newCircle));
        }
    }
}