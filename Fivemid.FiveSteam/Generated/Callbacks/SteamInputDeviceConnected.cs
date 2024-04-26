using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamInputDeviceConnected_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInputDeviceConnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInputDeviceConnected;
        /// missing documentation for SteamInputDeviceConnected_t.m_ulConnectedDeviceHandle
        public InputHandle ulConnectedDeviceHandle;
    }
}