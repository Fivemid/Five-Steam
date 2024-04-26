using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Callback indicating that a user's stats have been unloaded.<br />
    /// <br />
    /// Call <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats#RequestUserStats" class="bb_apilink">ISteamGameServerStats::RequestUserStats</a> again to access stats for this user.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSStatsUnloaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSStatsUnloaded;
        /// <summary>User whose stats have been unloaded.</summary>
        public SteamId steamIDUser;
    }
}