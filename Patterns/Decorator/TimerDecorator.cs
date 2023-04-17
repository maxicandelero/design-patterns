using System.Diagnostics;

namespace design_patterns.Patterns.Decorator
{
    // Concrete Decorators call the wrapped object and alter its result in some
    // way.
    public class TimerDecorator : ServiceDecorator
    {
        public TimerDecorator(BaseService service) : base(service)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var result = base.Operation();
            stopwatch.Stop();

            return $"Time: {stopwatch.Elapsed} - {result}";
        }
    }
}