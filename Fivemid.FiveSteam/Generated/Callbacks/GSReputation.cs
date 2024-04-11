using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSReputation_t</summary>
    public unsafe struct GSReputation : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSReputation;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>uint32 m_unReputationScore</summary>
        public uint unReputationScore;
        /// <summary>bool m_bBanned</summary>
        public bool bBanned;
        /// <summary>uint32 m_unBannedIP</summary>
        public uint unBannedIP;
        /// <summary>uint16 m_usBannedPort</summary>
        public ushort usBannedPort;
        /// <summary>uint64 m_ulBannedGameID</summary>
        public ulong ulBannedGameID;
        /// <summary>uint32 m_unBanExpires</summary>
        public uint unBanExpires;
    }
}