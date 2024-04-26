using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Called when the game server reputation has been queried.<br />
    /// <br />
    /// Master server bans are by IP so it is possible to be banned even when the score is good if there is a bad server on another port.<br />
    /// This information can be used to determine which server is bad.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamGameServer#GetServerReputation" class="bb_apilink">ISteamGameServer::GetServerReputation</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSReputation : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSReputation;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
        /// <summary>The reputation score for the game server.</summary>
        public uint unReputationScore;
        /// <summary>Is the server is banned from the Steam master servers (<b>true</b>) or not (<b>false</b>)?</summary>
        public bool bBanned;
        /// <summary>The IP of the banned server. Only set if <code class="bb_code bb_code_inline nohighlight">m_bBanned</code> is <b>true</b>.</summary>
        public uint unBannedIP;
        /// <summary>The port of the banned server. Only set if <code class="bb_code bb_code_inline nohighlight">m_bBanned</code> is <b>true</b>.</summary>
        public ushort usBannedPort;
        /// <summary>The game ID the banned server is serving. Only set if <code class="bb_code bb_code_inline nohighlight">m_bBanned</code> is <b>true</b>.</summary>
        public ulong ulBannedGameID;
        /// <summary>The time when the ban expires, provided in Unix epoch format (seconds since Jan 1st 1970). Only set if <code class="bb_code bb_code_inline nohighlight">m_bBanned</code> is <b>true</b>.</summary>
        public uint unBanExpires;
    }
}