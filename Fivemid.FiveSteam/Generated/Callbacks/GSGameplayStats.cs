using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GSGameplayStats_t</summary>
    public unsafe struct GSGameplayStats : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSGameplayStats;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>int32 m_nRank</summary>
        public int nRank;
        /// <summary>uint32 m_unTotalConnects</summary>
        public uint unTotalConnects;
        /// <summary>uint32 m_unTotalMinutesPlayed</summary>
        public uint unTotalMinutesPlayed;
    }
}