using design_patterns.Patterns.Proxy;
using Xunit;

namespace design_patterns.Patterns.Tests.Proxy
{
    public class ProxyTest
    {
        [Fact]
        public void get_request_without_check_access()
        {   
            RealSubject client = new RealSubject();

            string result = client.Request();

            Assert.Equal("RealSubject: Handling Request.", result);
        }

        [Fact]
        public void get_request_with_check_access()
        {   
            RealSubject client = new RealSubject();
            var proxy = new SubjectProxy(client);

            string result = proxy.Request();

            Assert.Equal("Proxy: Logging the time of request.", result);
        }
    }
}