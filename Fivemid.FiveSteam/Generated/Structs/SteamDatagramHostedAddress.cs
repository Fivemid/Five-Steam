using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamDatagramHostedAddress</summary>
    public unsafe struct SteamDatagramHostedAddress
    {
        /// <summary>int m_cbSize</summary>
        public int cbSize;
        /// <summary>char [128] m_data</summary>
        public UTF8String128 data;
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamDatagramHostedAddress_Clear", CallingConvention = Platform.CC)]
        internal static extern void Clear(SteamDatagramHostedAddress* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamDatagramHostedAddress_GetPopID", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingPOPID GetPopID(SteamDatagramHostedAddress* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamDatagramHostedAddress_SetDevAddress", CallingConvention = Platform.CC)]
        internal static extern void SetDevAddress(SteamDatagramHostedAddress* self, uint nIP, ushort nPort, SteamNetworkingPOPID popid);
        public void Clear()
        {
            fixed (SteamDatagramHostedAddress* self = &this)
                Clear(self);
        }

        public SteamNetworkingPOPID GetPopID()
        {
            fixed (SteamDatagramHostedAddress* self = &this)
                return GetPopID(self);
        }

        public void SetDevAddress(uint nIP, ushort nPort, SteamNetworkingPOPID popid)
        {
            fixed (SteamDatagramHostedAddress* self = &this)
                SetDevAddress(self, nIP, nPort, popid);
        }
    }
}