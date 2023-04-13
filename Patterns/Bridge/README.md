# Bridge

**Adapter is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.**

One of these hierarchies (often called the Abstraction) will get a reference to an object of the second hierarchy (Implementation). The abstraction will be able to delegate some (sometime, most) of its calls to the implementation object. Since all implementations will have a common interface, they'd be interchangeable inside the abstraction.

## Example

Suppose, you want to turn on the TV or turn off the TV, then what you can do here is, you can use the Remote Control to turn On/Off the TV. The Implementation will be done by the original TV implementer. So, in this case, Samsung TV or Sony TV will implement the turn On or turn Off functionality. So, the abstraction will use one of the implementers to turn on or turn off the TV.

Suppose, later you want to add a new implementation then you can do this in the Implementation Layer. For example, you can add new TV (for example Panasonic TV) in the Implementation Layer which will not affect the Abstraction Layer. You can also add a new Panasonic TV Remote Control in the Abstraction Layer without affecting the Implementation Layer. So, this is one of the best examples of the Bridge Design Pattern.