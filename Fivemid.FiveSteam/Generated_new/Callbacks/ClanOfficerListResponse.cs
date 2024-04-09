using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ClanOfficerListResponse_t</summary>
    public unsafe struct ClanOfficerListResponse
    {
        /// <summary>CSteamID m_steamIDClan</summary>
        public SteamId steamIDClan;
        /// <summary>int m_cOfficers</summary>
        public int cOfficers;
        /// <summary>uint8 m_bSuccess</summary>
        public byte bSuccess;
    }
}