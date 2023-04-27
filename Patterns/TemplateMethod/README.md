# Template Method

**Template Method is a behavioral design pattern that allows you to defines a skeleton of an algorithm in a base class and let subclasses override the steps without changing the overall algorithm's structure.**

The base class contains the skeleton of the algorithm. Each step is defined in a separate method, which can be either abstract or have some default implementation. The base class may also provide some default implementation of the whole algorithm.

## Example

Implementing credit cards validator. For different kind of credit cards (Visa, MasterCard and etc) the validation algorithm is the same: need to check expiration date, length of the credit card number, account status and etc. But the actual implementation for each credit card type may be different.
