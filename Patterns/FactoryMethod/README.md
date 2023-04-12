# Factory Method

**Factory Method is a creational design pattern which solves the problem of creating product objects without specifying their concrete classes.**

The Factory Method define a method, which should be used for creating objects instead of using a direct constructor call (`new` operator). Subclasses can override this method to change the class of objects that will be created.

## Example

Consider building a Logger Framework where the log messages maybe written into the log file (represented by FileLogger class) or displayed in the console (represented by ConsoleLogger class). Depending on some logic (for example the variable “logger.logToFile=true” stored in some properties file), an appropriate Logger implementer needs to be used to log messages . The Logger Framework may be used by many different clients, therefor it would be great idea to keep all the logic of creation and instantiation of the objects away from the clients. In this way, the client objects will not have to repeat the same logic again and again and it will be totally isolated from the future changes (like extension of Logger Framework by adding XmlLogger).