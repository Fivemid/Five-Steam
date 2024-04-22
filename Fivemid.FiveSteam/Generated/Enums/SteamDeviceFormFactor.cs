using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>The form factor of a device<br />
    /// <br />
    /// 
    /// </summary>
    public enum SteamDeviceFormFactor : int
    {
        /// <summary>The device form factor isn't available.</summary>
        Unknown = 0,
        /// <summary>The device is a phone or other small handheld device with touchscreen.</summary>
        Phone = 1,
        /// <summary>The device is a tablet or other large handheld device with a touchscreen.</summary>
        Tablet = 2,
        /// <summary>The device is a desktop computer or laptop.</summary>
        Computer = 3,
        /// <summary>The device is a TV.</summary>
        TV = 4,
        /// missing documentation for ESteamDeviceFormFactor.k_ESteamDeviceFormFactorVRHeadset
        VRHeadset = 5
    }
}