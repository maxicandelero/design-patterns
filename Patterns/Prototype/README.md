# Prototype

**Prototype is a creational design pattern that allows cloning objects, even complex one, without coupling to their specific classes.**

All prototype classes should have a common interface that makes it possible to copy objects even if their concrete classes are unknown. Prototype objects can produce full copies since objects of the same class can access each other's private fields.

The Prototype pattern is available in C# out of the box with a `ICloneable` interface.

## Example

Chess game — may be used for chess board creation, which may be time consuming. Using Prototype pattern, the board may be cloned, from the already existing board object.