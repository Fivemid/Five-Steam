using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>gameserveritem_t</summary>
    public unsafe struct gameserveritem
    {
        /// <summary>servernetadr_t m_NetAdr</summary>
        public servernetadr NetAdr;
        /// <summary>int m_nPing</summary>
        public int nPing;
        /// <summary>bool m_bHadSuccessfulResponse</summary>
        public bool bHadSuccessfulResponse;
        /// <summary>bool m_bDoNotRefresh</summary>
        public bool bDoNotRefresh;
        /// <summary>char [32] m_szGameDir</summary>
        public UTF8String32 szGameDir;
        /// <summary>char [32] m_szMap</summary>
        public UTF8String32 szMap;
        /// <summary>char [64] m_szGameDescription</summary>
        public UTF8String64 szGameDescription;
        /// <summary>uint32 m_nAppID</summary>
        public uint nAppID;
        /// <summary>int m_nPlayers</summary>
        public int nPlayers;
        /// <summary>int m_nMaxPlayers</summary>
        public int nMaxPlayers;
        /// <summary>int m_nBotPlayers</summary>
        public int nBotPlayers;
        /// <summary>bool m_bPassword</summary>
        public bool bPassword;
        /// <summary>bool m_bSecure</summary>
        public bool bSecure;
        /// <summary>uint32 m_ulTimeLastPlayed</summary>
        public uint ulTimeLastPlayed;
        /// <summary>int m_nServerVersion</summary>
        public int nServerVersion;
        /// <summary>char [64] m_szServerName</summary>
        public UTF8String64 szServerName;
        /// <summary>char [128] m_szGameTags</summary>
        public UTF8String128 szGameTags;
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
    }
}