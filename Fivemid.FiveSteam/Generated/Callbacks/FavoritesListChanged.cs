using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FavoritesListChanged_t</summary>
    public unsafe struct FavoritesListChanged
    {
        /// <summary>uint32 m_nIP</summary>
        public uint nIP;
        /// <summary>uint32 m_nQueryPort</summary>
        public uint nQueryPort;
        /// <summary>uint32 m_nConnPort</summary>
        public uint nConnPort;
        /// <summary>uint32 m_nAppID</summary>
        public uint nAppID;
        /// <summary>uint32 m_nFlags</summary>
        public uint nFlags;
        /// <summary>bool m_bAdd</summary>
        public bool bAdd;
        /// <summary>AccountID_t m_unAccountId</summary>
        public AccountID unAccountId;
    }
}