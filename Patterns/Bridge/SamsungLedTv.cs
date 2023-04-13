using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns.Patterns.Bridge
{
    // This is going to be a class which implements the ILedTv interface and 
    // also provide the implementation details for the associated Abstraction class.
    // Each Concrete Implementation corresponds to a specific platform
    public class SamsungLedTv : ILedTv
    {
        public string SwitchOn()
        {
            return "Turning ON : Samsung TV";
        }
        public string SwitchOff()
        {
            return "Turning OFF : Samsung TV";
        }

        public string SetChannel(int channelNumber)
        {
            return $"Setting channel Number { channelNumber } on Samsung TV";
        }
    }
}