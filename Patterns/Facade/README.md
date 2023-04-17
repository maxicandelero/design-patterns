# Decorator

**Facade is a structural design pattern that provides a simplified (but limited) interface to a library, a framework, or any other complex set of classes.**

While Facade decreases the overall complexity of the application, it also helps to move unwanted dependencies to one place. Usually, facades manage the full lifecycle of objects they use. This means that the facade can create, configure, and even dispose of objects on behalf of the client.

## Example

 One example to look at would be saving a user to a database. You need to first validate all the user information, check that the email is not already taken, and then finally save the user to the database. This is a lot of work to do, and it would be nice if we could just call one method to do all of this for us. This is where a facade comes in. We can create a facade that will handle all of this for us.