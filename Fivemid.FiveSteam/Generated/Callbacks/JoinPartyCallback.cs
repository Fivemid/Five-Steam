using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This callback is used as a call response for <a href="https://partner.steamgames.com/doc/api/ISteamParties#JoinParty" class="bb_apilink">ISteamParties::JoinParty</a>. On success, you will have reserved a slot in the beacon-owner's party, and should use <b>m_rgchConnectString</b> to connect to their game and complete the process.<br />
    /// <br />
    /// </summary>
    public unsafe struct JoinPartyCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.JoinPartyCallback;
        /// <summary>The result of the attempt to join the party.</summary>
        public Result eResult;
        /// <summary>Beacon ID used in the attempt.</summary>
        public PartyBeaconID ulBeaconID;
        /// <summary>Creator of the beacon used in the attempt.</summary>
        public SteamId SteamIDBeaconOwner;
        /// <summary>If successful, a "join game" string for your game to use to complete the process of joining the desired party</summary>
        public UTF8String256 rgchConnectString;
    }
}