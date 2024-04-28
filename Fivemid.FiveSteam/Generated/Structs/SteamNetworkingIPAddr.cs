using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// Store an IP and port.<br />
    /// <br />
    /// IPv6 is always used; IPv4 is represented using "IPv4-mapped" addresses: IPv4 aa.bb.cc.dd =&gt; IPv6 ::ffff:aabb:ccdd.  (See <a href="https://tools.ietf.org/html/rfc4291#section-2.5.5.2" target="_blank" rel="noreferrer">RFC 4291</a> section 2.5.5.2.)<br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamNetworkingIPAddr
    {
        /// <summary></summary>
        public FixedArray_byte16 ipv6;
        /// <summary>Host byte order</summary>
        public ushort port;
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_Clear", CallingConvention = Platform.CC)]
        internal static extern void Clear(SteamNetworkingIPAddr* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros", CallingConvention = Platform.CC)]
        internal static extern bool IsIPv6AllZeros(SteamNetworkingIPAddr* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_SetIPv6", CallingConvention = Platform.CC)]
        internal static extern void SetIPv6(SteamNetworkingIPAddr* self, byte* ipv6, ushort nPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_SetIPv4", CallingConvention = Platform.CC)]
        internal static extern void SetIPv4(SteamNetworkingIPAddr* self, uint nIP, ushort nPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsIPv4", CallingConvention = Platform.CC)]
        internal static extern bool IsIPv4(SteamNetworkingIPAddr* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_GetIPv4", CallingConvention = Platform.CC)]
        internal static extern uint GetIPv4(SteamNetworkingIPAddr* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost", CallingConvention = Platform.CC)]
        internal static extern void SetIPv6LocalHost(SteamNetworkingIPAddr* self, ushort nPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsLocalHost", CallingConvention = Platform.CC)]
        internal static extern bool IsLocalHost(SteamNetworkingIPAddr* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_ToString", CallingConvention = Platform.CC)]
        internal static extern void ToString(SteamNetworkingIPAddr* self, byte* buf, uint cbBuf, bool bWithPort);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_ParseString", CallingConvention = Platform.CC)]
        internal static extern bool ParseString(SteamNetworkingIPAddr* self, UTF8StringPtr pszStr);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsEqualTo", CallingConvention = Platform.CC)]
        internal static extern bool Equals(SteamNetworkingIPAddr* self, ref SteamNetworkingIPAddr x);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_GetFakeIPType", CallingConvention = Platform.CC)]
        internal static extern SteamNetworkingFakeIPType GetFakeIPType(SteamNetworkingIPAddr* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamNetworkingIPAddr_IsFakeIP", CallingConvention = Platform.CC)]
        internal static extern bool IsFakeIP(SteamNetworkingIPAddr* self);
        public void Clear()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                Clear(self);
        }

        public bool IsIPv6AllZeros()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return IsIPv6AllZeros(self);
        }

        public void SetIPv6(byte* ipv6, ushort nPort)
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                SetIPv6(self, ipv6, nPort);
        }

        public void SetIPv4(uint nIP, ushort nPort)
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                SetIPv4(self, nIP, nPort);
        }

        public bool IsIPv4()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return IsIPv4(self);
        }

        public uint GetIPv4()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return GetIPv4(self);
        }

        public void SetIPv6LocalHost(ushort nPort)
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                SetIPv6LocalHost(self, nPort);
        }

        public bool IsLocalHost()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return IsLocalHost(self);
        }

        public void ToString(byte* buf, uint cbBuf, bool bWithPort)
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                ToString(self, buf, cbBuf, bWithPort);
        }

        public bool ParseString(UTF8StringPtr pszStr)
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return ParseString(self, pszStr);
        }

        public bool Equals(ref SteamNetworkingIPAddr x)
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return Equals(self, ref x);
        }

        public SteamNetworkingFakeIPType GetFakeIPType()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return GetFakeIPType(self);
        }

        public bool IsFakeIP()
        {
            fixed (SteamNetworkingIPAddr* self = &this)
                return IsFakeIP(self);
        }
    }
}