using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInputDeviceConnected_t</summary>
    public unsafe struct SteamInputDeviceConnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInputDeviceConnected;
        /// <summary>InputHandle_t m_ulConnectedDeviceHandle</summary>
        public InputHandle ulConnectedDeviceHandle;
    }
}