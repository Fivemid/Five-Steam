using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamNetworkingIdentity</summary>
    public unsafe struct SteamNetworkingIdentity
    {
        /// <summary>ESteamNetworkingIdentityType m_eType</summary>
        public SteamNetworkingIdentityType eType;
        /// <summary>int m_cbSize</summary>
        public int cbSize;
        /// <summary>char [128] m_szUnknownRawString</summary>
        public UTF8String128 szUnknownRawString;
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_Clear", CallingConvention = Platform.CC)]
        internal static extern void Clear(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsInvalid", CallingConvention = Platform.CC)]
        internal static extern bool IsInvalid(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetSteamID", CallingConvention = Platform.CC)]
        internal static extern void SetSteamID(SteamNetworkingIdentity* self, SteamId steamID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetSteamID", CallingConvention = Platform.CC)]
        internal static extern SteamId GetSteamID(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetSteamID64", CallingConvention = Platform.CC)]
        internal static extern void SetSteamID64(SteamNetworkingIdentity* self, ulong steamID);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetSteamID64", CallingConvention = Platform.CC)]
        internal static extern ulong GetSteamID64(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID", CallingConvention = Platform.CC)]
        internal static extern bool SetXboxPairwiseID(SteamNetworkingIdentity* self, UTF8StringPtr pszString);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetXboxPairwiseID(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetPSNID", CallingConvention = Platform.CC)]
        internal static extern void SetPSNID(SteamNetworkingIdentity* self, ulong id);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetPSNID", CallingConvention = Platform.CC)]
        internal static extern ulong GetPSNID(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetStadiaID", CallingConvention = Platform.CC)]
        internal static extern void SetStadiaID(SteamNetworkingIdentity* self, ulong id);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetStadiaID", CallingConvention = Platform.CC)]
        internal static extern ulong GetStadiaID(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetIPAddr", CallingConvention = Platform.CC)]
        internal static extern void SetIPAddr(SteamNetworkingIdentity* self, ref SteamNetworkingIPAddr addr);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetIPAddr", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingIPAddr* GetIPAddr(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetIPv4Addr", CallingConvention = Platform.CC)]
        internal static extern void SetIPv4Addr(SteamNetworkingIdentity* self, uint nIPv4, ushort nPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetIPv4", CallingConvention = Platform.CC)]
        internal static extern uint GetIPv4(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetFakeIPType", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingFakeIPType GetFakeIPType(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsFakeIP", CallingConvention = Platform.CC)]
        internal static extern bool IsFakeIP(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetLocalHost", CallingConvention = Platform.CC)]
        internal static extern void SetLocalHost(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsLocalHost", CallingConvention = Platform.CC)]
        internal static extern bool IsLocalHost(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetGenericString", CallingConvention = Platform.CC)]
        internal static extern bool SetGenericString(SteamNetworkingIdentity* self, UTF8StringPtr pszString);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetGenericString", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetGenericString(SteamNetworkingIdentity* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_SetGenericBytes", CallingConvention = Platform.CC)]
        internal static extern bool SetGenericBytes(SteamNetworkingIdentity* self, void* data, uint cbLen);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_GetGenericBytes", CallingConvention = Platform.CC)]
        internal static extern byte* GetGenericBytes(SteamNetworkingIdentity* self, ref int cbLen);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_IsEqualTo", CallingConvention = Platform.CC)]
        internal static extern bool Equals(SteamNetworkingIdentity* self, ref SteamNetworkingIdentity x);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_ToString", CallingConvention = Platform.CC)]
        internal static extern void ToString(SteamNetworkingIdentity* self, char* buf, uint cbBuf);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamNetworkingIdentity_ParseString", CallingConvention = Platform.CC)]
        internal static extern bool ParseString(SteamNetworkingIdentity* self, UTF8StringPtr pszStr);
        public void Clear()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                Clear(self);
        }

        public bool IsInvalid()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return IsInvalid(self);
        }

        public void SetSteamID(SteamId steamID)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetSteamID(self, steamID);
        }

        public SteamId GetSteamID()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetSteamID(self);
        }

        public void SetSteamID64(ulong steamID)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetSteamID64(self, steamID);
        }

        public ulong GetSteamID64()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetSteamID64(self);
        }

        public bool SetXboxPairwiseID(UTF8StringPtr pszString)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return SetXboxPairwiseID(self, pszString);
        }

        public UTF8StringPtr GetXboxPairwiseID()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetXboxPairwiseID(self);
        }

        public void SetPSNID(ulong id)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetPSNID(self, id);
        }

        public ulong GetPSNID()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetPSNID(self);
        }

        public void SetStadiaID(ulong id)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetStadiaID(self, id);
        }

        public ulong GetStadiaID()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetStadiaID(self);
        }

        public void SetIPAddr(ref SteamNetworkingIPAddr addr)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetIPAddr(self, ref addr);
        }

        public SteamNetworkingIPAddr* GetIPAddr()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetIPAddr(self);
        }

        public void SetIPv4Addr(uint nIPv4, ushort nPort)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetIPv4Addr(self, nIPv4, nPort);
        }

        public uint GetIPv4()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetIPv4(self);
        }

        public SteamNetworkingFakeIPType GetFakeIPType()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetFakeIPType(self);
        }

        public bool IsFakeIP()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return IsFakeIP(self);
        }

        public void SetLocalHost()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                SetLocalHost(self);
        }

        public bool IsLocalHost()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return IsLocalHost(self);
        }

        public bool SetGenericString(UTF8StringPtr pszString)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return SetGenericString(self, pszString);
        }

        public UTF8StringPtr GetGenericString()
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetGenericString(self);
        }

        public bool SetGenericBytes(void* data, uint cbLen)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return SetGenericBytes(self, data, cbLen);
        }

        public byte* GetGenericBytes(ref int cbLen)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return GetGenericBytes(self, ref cbLen);
        }

        public bool Equals(ref SteamNetworkingIdentity x)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return Equals(self, ref x);
        }

        public void ToString(char* buf, uint cbBuf)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                ToString(self, buf, cbBuf);
        }

        public bool ParseString(UTF8StringPtr pszStr)
        {
            fixed (SteamNetworkingIdentity* self = &this)
                return ParseString(self, pszStr);
        }
    }
}