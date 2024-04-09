using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInputDeviceDisconnected_t</summary>
    public unsafe struct SteamInputDeviceDisconnected
    {
        /// <summary>InputHandle_t m_ulDisconnectedDeviceHandle</summary>
        public InputHandle ulDisconnectedDeviceHandle;
    }
}