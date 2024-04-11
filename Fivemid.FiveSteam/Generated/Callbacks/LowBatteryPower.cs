using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>LowBatteryPower_t</summary>
    public unsafe struct LowBatteryPower : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.LowBatteryPower;
        /// <summary>uint8 m_nMinutesBatteryLeft</summary>
        public byte nMinutesBatteryLeft;
    }
}