using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Called when gameplay stats info has been queried using <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GetGameplayStats" class="bb_apilink">ISteamGameServer::GetGameplayStats</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GetGameplayStats" class="bb_apilink">ISteamGameServer::GetGameplayStats</a></summary>
    public unsafe struct GSGameplayStats : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSGameplayStats;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The overall rank of the server (0-based).</summary>
        public int nRank;
        /// <summary>Total number of clients who have ever connected to the server.</summary>
        public uint unTotalConnects;
        /// <summary>Total number of minutes ever played on the server.</summary>
        public uint unTotalMinutesPlayed;
    }
}