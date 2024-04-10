using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>FriendsEnumerateFollowingList_t</summary>
    public unsafe struct FriendsEnumerateFollowingList
    {
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID [50] m_rgSteamID</summary>
        public FixedArray_ulong50 rgSteamID;
        /// <summary>int32 m_nResultsReturned</summary>
        public int nResultsReturned;
        /// <summary>int32 m_nTotalResultCount</summary>
        public int nTotalResultCount;
    }
}