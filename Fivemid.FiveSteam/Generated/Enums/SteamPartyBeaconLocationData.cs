using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ESteamPartyBeaconLocationData</summary>
    public enum SteamPartyBeaconLocationData : int
    {
        /// <summary>k_ESteamPartyBeaconLocationDataInvalid</summary>
        Invalid = 0,
        /// <summary>k_ESteamPartyBeaconLocationDataName</summary>
        Name = 1,
        /// <summary>k_ESteamPartyBeaconLocationDataIconURLSmall</summary>
        IconURLSmall = 2,
        /// <summary>k_ESteamPartyBeaconLocationDataIconURLMedium</summary>
        IconURLMedium = 3,
        /// <summary>k_ESteamPartyBeaconLocationDataIconURLLarge</summary>
        IconURLLarge = 4
    }
}