using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>servernetadr_t</summary>
    public unsafe struct servernetadr
    {
        /// <summary>uint16 m_usConnectionPort</summary>
        public ushort usConnectionPort;
        /// <summary>uint16 m_usQueryPort</summary>
        public ushort usQueryPort;
        /// <summary>uint32 m_unIP</summary>
        public uint unIP;
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_Construct", CallingConvention = Platform.CC)]
        internal static extern void Construct(servernetadr* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_Init", CallingConvention = Platform.CC)]
        internal static extern void Init(servernetadr* self, uint ip, ushort usQueryPort, ushort usConnectionPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_GetQueryPort", CallingConvention = Platform.CC)]
        internal static extern ushort GetQueryPort(servernetadr* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_SetQueryPort", CallingConvention = Platform.CC)]
        internal static extern void SetQueryPort(servernetadr* self, ushort usPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_GetConnectionPort", CallingConvention = Platform.CC)]
        internal static extern ushort GetConnectionPort(servernetadr* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_SetConnectionPort", CallingConvention = Platform.CC)]
        internal static extern void SetConnectionPort(servernetadr* self, ushort usPort);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_GetIP", CallingConvention = Platform.CC)]
        internal static extern uint GetIP(servernetadr* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_SetIP", CallingConvention = Platform.CC)]
        internal static extern void SetIP(servernetadr* self, uint unIP);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_GetConnectionAddressString", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetConnectionAddressString(servernetadr* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_GetQueryAddressString", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetQueryAddressString(servernetadr* self);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_IsLessThan", CallingConvention = Platform.CC)]
        internal static extern bool LessThan(servernetadr* self, ref servernetadr netadr);
        [DllImport(Platform.LibraryName, EntryPoint = "SteamAPI_servernetadr_t_Assign", CallingConvention = Platform.CC)]
        internal static extern void Assign(servernetadr* self, ref servernetadr that);
        public void Construct()
        {
            fixed (servernetadr* self = &this)
                Construct(self);
        }

        public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
        {
            fixed (servernetadr* self = &this)
                Init(self, ip, usQueryPort, usConnectionPort);
        }

        public ushort GetQueryPort()
        {
            fixed (servernetadr* self = &this)
                return GetQueryPort(self);
        }

        public void SetQueryPort(ushort usPort)
        {
            fixed (servernetadr* self = &this)
                SetQueryPort(self, usPort);
        }

        public ushort GetConnectionPort()
        {
            fixed (servernetadr* self = &this)
                return GetConnectionPort(self);
        }

        public void SetConnectionPort(ushort usPort)
        {
            fixed (servernetadr* self = &this)
                SetConnectionPort(self, usPort);
        }

        public uint GetIP()
        {
            fixed (servernetadr* self = &this)
                return GetIP(self);
        }

        public void SetIP(uint unIP)
        {
            fixed (servernetadr* self = &this)
                SetIP(self, unIP);
        }

        public UTF8StringPtr GetConnectionAddressString()
        {
            fixed (servernetadr* self = &this)
                return GetConnectionAddressString(self);
        }

        public UTF8StringPtr GetQueryAddressString()
        {
            fixed (servernetadr* self = &this)
                return GetQueryAddressString(self);
        }

        public bool LessThan(ref servernetadr netadr)
        {
            fixed (servernetadr* self = &this)
                return LessThan(self, ref netadr);
        }

        public void Assign(ref servernetadr that)
        {
            fixed (servernetadr* self = &this)
                Assign(self, ref that);
        }
    }
}