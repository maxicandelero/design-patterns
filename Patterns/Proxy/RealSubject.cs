namespace design_patterns.Patterns.Proxy
{
    public class RealSubject : ISubject
    {
        // The RealSubject contains some core business logic. Usually, RealSubjects
        // are capable of doing some useful work which may also be very slow or
        // sensitive - e.g. correcting input data. A Proxy can solve these issues
        // without any changes to the RealSubject's code.
        public string Request()
        {
            return "RealSubject: Handling Request.";
        }
    }
}