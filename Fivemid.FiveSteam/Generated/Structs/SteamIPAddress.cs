using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamIPAddress_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamIPAddress
    {
        /// missing documentation for SteamIPAddress_t.m_rgubIPv6
        public FixedArray_byte16 rgubIPv6;
        /// missing documentation for SteamIPAddress_t.m_eType
        public SteamIPType eType;
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_SteamIPAddress_t_IsSet", CallingConvention = Platform.CC)]
        internal static extern bool IsSet(SteamIPAddress* self);
        public bool IsSet()
        {
            fixed (SteamIPAddress* self = &this)
                return IsSet(self);
        }
    }
}