using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamInputDeviceDisconnected_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInputDeviceDisconnected : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInputDeviceDisconnected;
        /// missing documentation for SteamInputDeviceDisconnected_t.m_ulDisconnectedDeviceHandle
        public InputHandle ulDisconnectedDeviceHandle;
    }
}