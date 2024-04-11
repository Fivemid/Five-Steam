using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInputDeviceDisconnected_t</summary>
    public unsafe struct SteamInputDeviceDisconnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInputDeviceDisconnected;
        /// <summary>InputHandle_t m_ulDisconnectedDeviceHandle</summary>
        public InputHandle ulDisconnectedDeviceHandle;
    }
}