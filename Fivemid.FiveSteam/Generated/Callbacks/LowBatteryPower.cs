using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when running on a laptop and less than 10 minutes of battery is left, and then fires then every minute afterwards.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct LowBatteryPower
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LowBatteryPower;
        /// <summary>The estimated amount of battery life left in minutes.</summary>
        public byte nMinutesBatteryLeft;
    }
}