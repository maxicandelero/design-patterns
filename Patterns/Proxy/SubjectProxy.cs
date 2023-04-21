namespace design_patterns.Patterns.Proxy
{
    public class SubjectProxy : ISubject
    {
        private RealSubject _realSubject;
        
        public SubjectProxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }
        
        public string Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                return this.LogAccess();
            }
            return "Proxy: Access denied.";
        }
        
        public bool CheckAccess()
        {
            // Some real checks should go here.
            return true;
        }
        
        public string LogAccess()
        {
            return "Proxy: Logging the time of request.";
        }
    }
}