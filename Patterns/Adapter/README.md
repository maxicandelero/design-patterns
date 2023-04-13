# Adapter

**Adapter is a structural design pattern, which allows incompatible objects to collaborate.**

The Adaptar acts as a wrapper between two objects. It catches calls for one object and transforms them to format and interface recognizable by the second object.

## Example

You have an old service which returns weather (in celsius) by passing city name as a input value. Now, assume that your client wants to pass zipcode as input and expecting the temperature of the city in return. Here you need an adaptor to achieve this.