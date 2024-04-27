using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Returns the result of <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFollowerCount" class="bb_apilink">ISteamFriends::GetFollowerCount</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetFollowerCount" class="bb_apilink">ISteamFriends::GetFollowerCount</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct FriendsGetFollowerCount
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FriendsGetFollowerCount;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The Steam ID of the user we requested the follower count for.</summary>
        public SteamId steamID;
        /// <summary>The number of followers the user has.</summary>
        public int nCount;
    }
}