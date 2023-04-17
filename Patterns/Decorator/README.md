# Decorator

**Decorator is a structural pattern that allows adding new behaviors to objects dynamically by placing them inside special wrapper objects, called Decorators.**

Using decorators you can wrap objects countless number of times since both target objects and decorators follow the same interface. The resulting object will get a stacking behavior af all wrappers.

## Example

When you need to measure the time it takes to handle some web service request. The class TimerDecorator with timer capabilities should be created, which will start the timer when request received and will stop the timer when response sent back.