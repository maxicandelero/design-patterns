# Chain of Responsibility

**Chain of Responsability is behavioral design pattern that allows passing request along the chain of potential handlers until one of them handles request.**

The pattern allows multiple objects to handle the request without coupling sender class to the concrete classes of the receivers. The chain can be composed dynamically at runtime with any handler that follows a standard handler interface.

## Example

One of the great example of Chain of Responsibility pattern is ATM Dispense machine. The user enters the amount to be dispensed and the machine dispense amount in terms of defined currency bills such as 50$, 20$, 10$ etc. If the user enters an amount that is not multiples of 10, it throws error.

