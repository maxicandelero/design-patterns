# Proxy

**Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client. A proxy receives client request, does some work (access control, caching, etc.) and then passes the request to a service object.**

The proxy object has the same interface as a service object, which makes it interchangeable with the real object when passed to a client.

## Example

The most common applications of the Proxy pattern are lazy loading, caching, controlling the access, logging, etc. A Proxy can perform one of these things and then, depending on the result, pass the execution to the same method in a linked RealSubject object. Maybe used also for adding a thread-safe feature to an existing class without changing the existing class’s code.