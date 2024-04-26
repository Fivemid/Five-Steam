using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Callback indicating that a user's stats have been unloaded.<br />
    /// <br />
    /// Call <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#RequestUserStats" class="bb_apilink">ISteamUserStats::RequestUserStats</a> again before accessing stats for this user.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UserStatsUnloaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserStatsUnloaded;
        /// <summary>User whose stats have been unloaded.</summary>
        public SteamId steamIDUser;
    }
}