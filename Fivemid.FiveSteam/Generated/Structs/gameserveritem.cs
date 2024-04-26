using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for gameserveritem_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct gameserveritem
    {
        /// missing documentation for gameserveritem_t.m_NetAdr
        public servernetadr NetAdr;
        /// missing documentation for gameserveritem_t.m_nPing
        public int nPing;
        /// missing documentation for gameserveritem_t.m_bHadSuccessfulResponse
        public bool bHadSuccessfulResponse;
        /// missing documentation for gameserveritem_t.m_bDoNotRefresh
        public bool bDoNotRefresh;
        /// missing documentation for gameserveritem_t.m_szGameDir
        public UTF8String32 szGameDir;
        /// missing documentation for gameserveritem_t.m_szMap
        public UTF8String32 szMap;
        /// missing documentation for gameserveritem_t.m_szGameDescription
        public UTF8String64 szGameDescription;
        /// missing documentation for gameserveritem_t.m_nAppID
        public uint nAppID;
        /// missing documentation for gameserveritem_t.m_nPlayers
        public int nPlayers;
        /// missing documentation for gameserveritem_t.m_nMaxPlayers
        public int nMaxPlayers;
        /// missing documentation for gameserveritem_t.m_nBotPlayers
        public int nBotPlayers;
        /// missing documentation for gameserveritem_t.m_bPassword
        public bool bPassword;
        /// missing documentation for gameserveritem_t.m_bSecure
        public bool bSecure;
        /// missing documentation for gameserveritem_t.m_ulTimeLastPlayed
        public uint ulTimeLastPlayed;
        /// missing documentation for gameserveritem_t.m_nServerVersion
        public int nServerVersion;
        /// missing documentation for gameserveritem_t.m_szServerName
        public UTF8String64 szServerName;
        /// missing documentation for gameserveritem_t.m_szGameTags
        public UTF8String128 szGameTags;
        /// missing documentation for gameserveritem_t.m_steamID
        public SteamId steamID;
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_gameserveritem_t_Construct", CallingConvention = Platform.CC)]
        internal static extern void Construct(gameserveritem* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_gameserveritem_t_GetName", CallingConvention = Platform.CC)]
        internal static extern UTF8StringPtr GetName(gameserveritem* self);
        [DllImport(Platform.LIBRARY_NAME, EntryPoint = "SteamAPI_gameserveritem_t_SetName", CallingConvention = Platform.CC)]
        internal static extern void SetName(gameserveritem* self, UTF8StringPtr pName);
        public void Construct()
        {
            fixed (gameserveritem* self = &this)
                Construct(self);
        }

        public UTF8StringPtr GetName()
        {
            fixed (gameserveritem* self = &this)
                return GetName(self);
        }

        public void SetName(UTF8StringPtr pName)
        {
            fixed (gameserveritem* self = &this)
                SetName(self, pName);
        }
    }
}