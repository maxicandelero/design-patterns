namespace design_patterns.Patterns.Decorator
{
    // The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.
    public abstract class ServiceDecorator : BaseService
    {
        protected BaseService _service;

        public ServiceDecorator(BaseService service)
        {
            this._service = service;
        }

        public void SetComponent(BaseService service)
        {
            this._service = service;
        }

        // The Decorator delegates all work to the wrapped component.
        public override string Operation()
        {
            if (this._service != null)
            {
                return this._service.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}