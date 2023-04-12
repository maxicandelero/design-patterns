# Builder

**Builder is a creational design pattern, which allows constructing complex objects step by step.**

Unlike other creational patterns, Builder doesn't require products to have a common interface. That makes it possible to produce different products using the same construction process.

## Example

Did it happen to you, that you had to use constructor with 5 or even more parameters? For example, to create a Pizza object, you need to call the following constructor:

```cs
Pizza(Size size, Boolean onion, Boolean cheese, Boolean olives, Boolean tomato, Boolean corn, Boolean mushroom, Sauce sauceType);
```

In addition to the fact that it’s annoying, the parameters maybe easily mixed up by the developers. Usually, most of the parameters are not even mandatory, but in this constructor, the user forced to set value for each of the parameters. What will happen when new ingredients will be added? Should this constructor be extended with even more parameters?.

Exactly for those cases, when a lot of parameters needed to build the object — Builder design pattern is used! The main idea is to separate required fields from an optional and to move the construction logic out of the object class to a separate static inner class referred to as a builder class. That Builder class has a constructor only for mandatory parameters and setter methods for all the optional parameters. In addition, there is a build() method which glues everything together and returns immutable complete object. All the builder setter methods return the builder itself, so the invocations can be chained.

So, our Pizza object creation, after applying a builder pattern will look like this:

```cs
Pizza pizza = new PizzaBuilder().Size(PizzaSize.Medium).AddSauce().AddCheese().AddOnions().Build();;
```

Note, that Pizza class should not have any public constructor at all and the objects will be created only using the Builder class.