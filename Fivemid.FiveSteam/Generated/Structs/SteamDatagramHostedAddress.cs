using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamDatagramHostedAddress
    public unsafe struct SteamDatagramHostedAddress
    {
        /// missing documentation for SteamDatagramHostedAddress.m_cbSize
        public int cbSize;
        /// missing documentation for SteamDatagramHostedAddress.m_data
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