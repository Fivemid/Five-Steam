using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a UGC query request completes.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#SendQueryUGCRequest" class="bb_apilink">ISteamUGC::SendQueryUGCRequest</a></summary>
    public unsafe struct SteamUGCQueryCompleted : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamUGCQueryCompleted;
        /// <summary>The UGC query handle associated with this call result.</summary>
        public UGCQueryHandle handle;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The number of items returned in this result set.</summary>
        public uint unNumResultsReturned;
        /// <summary>The total number of items that matched the query in the database.</summary>
        public uint unTotalMatchingResults;
        /// <summary>Indicates whether this data was retrieved from the local on-disk cache.</summary>
        public bool bCachedData;
        /// missing documentation for SteamUGCQueryCompleted_t.m_rgchNextCursor
        public UTF8String256 rgchNextCursor;
    }
}