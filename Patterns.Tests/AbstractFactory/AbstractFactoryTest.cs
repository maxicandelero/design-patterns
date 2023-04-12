using design_patterns.Patterns.AbstractFactory;
using Xunit;

namespace design_patterns.Patterns.Tests.AbstractFactory
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void device_provider_should_work_in_local_mode()
        {   
            IDeviceProviderFactory factory = new LocalDeviceProviderFactory();
            
            IAndroidDeviceProvider android = factory.CreateAndroidDeviceProvider();
            IIOSDeviceProvider iOS = factory.CreateIOSDeviceProvider();
            IDeviceProviderSettings settings = factory.CreateDeviceProviderSettings();

            Assert.Equal("Local custom settings", settings.GetDeviceProviderSettings());
            Assert.Equal("Android device is running in Local mode. Settings: Default.", android.UsefulFunctionInAndroid());
            Assert.Equal($"Android device is running in Local mode. Settings: { settings.GetDeviceProviderSettings() }.", android.UsefulFunctionInAndroid(settings));
            Assert.Equal("iOS device is running in Local mode. Settings: Default.", iOS.UsefulFunctionInIOS());
            Assert.Equal($"iOS device is running in Local mode. Settings: { settings.GetDeviceProviderSettings() }.", iOS.UsefulFunctionInIOS(settings));
        }

        [Fact]
        public void device_provider_should_work_in_remote_mode()
        {   
            IDeviceProviderFactory factory = new RemoteDeviceProviderFactory();
            
            IAndroidDeviceProvider android = factory.CreateAndroidDeviceProvider();
            IIOSDeviceProvider iOS = factory.CreateIOSDeviceProvider();
            IDeviceProviderSettings settings = factory.CreateDeviceProviderSettings();

            Assert.Equal("Remote custom settings", settings.GetDeviceProviderSettings());
            Assert.Equal("Android device is running in Remote mode. Settings: Default.", android.UsefulFunctionInAndroid());
            Assert.Equal($"Android device is running in Remote mode. Settings: { settings.GetDeviceProviderSettings() }.", android.UsefulFunctionInAndroid(settings));
            Assert.Equal("iOS device is running in Remote mode. Settings: Default.", iOS.UsefulFunctionInIOS());
            Assert.Equal($"iOS device is running in Remote mode. Settings: { settings.GetDeviceProviderSettings() }.", iOS.UsefulFunctionInIOS(settings));
        }
    }
}