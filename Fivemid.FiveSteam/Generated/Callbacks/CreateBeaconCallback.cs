using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>This callback is used as a call response for <a href="https://partner.steamgames.com/doc/api/ISteamParties#CreateBeacon" class="bb_apilink">ISteamParties::CreateBeacon</a>. If successful, your beacon has been posted in the desired location and you may start receiving <a href="https://partner.steamgames.com/doc/api/ISteamParties#ReservationNotificationCallback_t" class="bb_apilink">ISteamParties::ReservationNotificationCallback_t</a> callbacks for users following the beacon. <br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct CreateBeaconCallback
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.CreateBeaconCallback;
        /// <summary>The result of the attempt to create a beacon.</summary>
        public Result eResult;
        /// <summary>Beacon ID of the newly created beacon.</summary>
        public PartyBeaconID ulBeaconID;
    }
}