using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Returns the result of
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#IsFollowing" class="bb_apilink">ISteamFriends::IsFollowing</a>.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#IsFollowing" class="bb_apilink">ISteamFriends::IsFollowing</a>
    /// </summary>
    public unsafe struct FriendsIsFollowing : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.FriendsIsFollowing;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The Steam ID that was checked.</summary>
        public SteamId steamID;
        /// <summary>Are we following the user? (<b>true</b>) or not? (<b>false</b>)</summary>
        public bool bIsFollowing;
    }
}