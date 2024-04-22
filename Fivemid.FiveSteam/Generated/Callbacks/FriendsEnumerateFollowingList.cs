using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Returns the result of <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EnumerateFollowingList" class="bb_apilink">ISteamFriends::EnumerateFollowingList</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EnumerateFollowingList" class="bb_apilink">ISteamFriends::EnumerateFollowingList</a></summary>
    public unsafe struct FriendsEnumerateFollowingList : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FriendsEnumerateFollowingList;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The list of users that we are following.</summary>
        public FixedArray_ulong50 rgSteamID;
        /// <summary>The number of results returned in <code class="bb_code bb_code_inline nohighlight">m_rgSteamID</code>.</summary>
        public int nResultsReturned;
        /// <summary>The total number of people we are following. If this is greater than <code class="bb_code bb_code_inline nohighlight">m_nResultsReturned</code> Then you should make a subsequent call to <a href="https://partner.steamgames.com/doc/api/ISteamFriends#EnumerateFollowingList" class="bb_apilink">ISteamFriends::EnumerateFollowingList</a> with <code class="bb_code bb_code_inline nohighlight">m_nResultsReturned</code> as the index to get the next portion of followers.</summary>
        public int nTotalResultCount;
    }
}