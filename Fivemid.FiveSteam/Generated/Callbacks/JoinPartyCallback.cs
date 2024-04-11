using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>JoinPartyCallback_t</summary>
    public unsafe struct JoinPartyCallback : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.JoinPartyCallback;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>PartyBeaconID_t m_ulBeaconID</summary>
        public PartyBeaconID ulBeaconID;
        /// <summary>CSteamID m_SteamIDBeaconOwner</summary>
        public SteamId SteamIDBeaconOwner;
        /// <summary>char [256] m_rgchConnectString</summary>
        public UTF8String256 rgchConnectString;
    }
}