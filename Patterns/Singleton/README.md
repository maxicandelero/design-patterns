# Singleton Pattern

**Singleton is a creational design pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.**

Singleton has almost the same pros and cons as global variables. Although they're super-handy, they break the modularity of your code.

You can't just use a class that depends on a Singleton in some other context, without carrying over the Singleton to the other context. Most of the time, this limitation comes up during the creation of unit tests.

Singleton can be recognized by a static creation method, which returns the same cache object.

## Naïve Singleton

It's pretty easy to implement a sloppy Singleton. You just need to hide the constructor and implement a static creation method.

The same class behaves incorrectly in a multithreaded environment. Multi threads can call the cration method simultaneously and get several instances of Singleton class.

## Thread-safe Singleton

To fix the problem, you have to synchronize threads during the first creation of the Singleton object.