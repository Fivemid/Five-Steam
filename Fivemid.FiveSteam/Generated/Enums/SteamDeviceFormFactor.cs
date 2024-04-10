using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamDeviceFormFactor</summary>
    public enum SteamDeviceFormFactor : int
    {
        /// <summary>k_ESteamDeviceFormFactorUnknown</summary>
        Unknown = 0,
        /// <summary>k_ESteamDeviceFormFactorPhone</summary>
        Phone = 1,
        /// <summary>k_ESteamDeviceFormFactorTablet</summary>
        Tablet = 2,
        /// <summary>k_ESteamDeviceFormFactorComputer</summary>
        Computer = 3,
        /// <summary>k_ESteamDeviceFormFactorTV</summary>
        TV = 4,
        /// <summary>k_ESteamDeviceFormFactorVRHeadset</summary>
        VRHeadset = 5
    }
}