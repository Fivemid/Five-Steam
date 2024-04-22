using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Types of extended metadata for beacon locations.<br />
    /// <br />
    /// </summary>
    public enum SteamPartyBeaconLocationData : int
    {
        /// <summary>Invalid location data type.</summary>
        Invalid = 0,
        /// <summary>The name, if any, of the location</summary>
        Name = 1,
        /// <summary>If the location has an associated icon, this is the URL for the small format icon image.</summary>
        IconURLSmall = 2,
        /// <summary>If the location has an associated icon, this is the URL for the medium format icon image.</summary>
        IconURLMedium = 3,
        /// <summary>If the location has an associated icon, this is the URL for the small large icon image.</summary>
        IconURLLarge = 4
    }
}