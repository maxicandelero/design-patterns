using design_patterns.Patterns.Bridge;
using Xunit;

namespace design_patterns.Patterns.Tests.Bridge
{
    public class BridgeTest
    {
        [Fact]
        public void client_uses_sony_remote_control()
        {   
            ushort channel = 101;
            AbstractRemoteControl remoteControl = new SonyRemoteControl(new SonyLedTv());

            string switchOn = remoteControl.SwitchOn();
            string setChannel = remoteControl.SetChannel(channel);
            string switchOff = remoteControl.SwitchOff();
            
            Assert.Equal("Turning ON : Sony TV", switchOn);
            Assert.Equal($"Setting channel Number { channel } on Sony TV", setChannel);
            Assert.Equal("Turning OFF : Sony TV", switchOff);
        }

        [Fact]
        public void client_uses_samsung_remote_control()
        {   
            ushort channel = 101;
            AbstractRemoteControl remoteControl = new SamsungRemoteControl(new SamsungLedTv());

            string switchOn = remoteControl.SwitchOn();
            string setChannel = remoteControl.SetChannel(channel);
            string switchOff = remoteControl.SwitchOff();
            
            Assert.Equal("Turning ON : Samsung TV", switchOn);
            Assert.Equal($"Setting channel Number { channel } on Samsung TV", setChannel);
            Assert.Equal("Turning OFF : Samsung TV", switchOff);
        }
    }
}