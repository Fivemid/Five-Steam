using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamIPAddress_t</summary>
    public unsafe struct SteamIPAddress
    {
        /// <summary>uint8 [16] m_rgubIPv6</summary>
        public FixedArray_byte16 rgubIPv6;
        /// <summary>ESteamIPType m_eType</summary>
        public SteamIPType eType;
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_SteamIPAddress_t_IsSet", CallingConvention = Platform.CC)]
        internal static extern bool IsSet(SteamIPAddress* self);
        public bool IsSet()
        {
            fixed (SteamIPAddress* self = &this)
                return IsSet(self);
        }
    }
}