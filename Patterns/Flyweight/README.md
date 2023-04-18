# Flyweight

**Flyweight is a structural design pattern that allows programs to support vast quantities of ojbects by keeping their memory consumption low.**

The pattern achieves it by sharing parts of objects state between multiple objects. In other words, the Flyweight saves RAM by caching the data used by different objects.

## Example 

When drawing a lot of shapes with different colors and types: one object for red circle, one object for blue rectangle and so on. In case red circle was already created once, there is no need to create new such object, since the same object may be reused. This shapes have different positions, so we can set the X and Y coordinates of the shape object.

