using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when workshop item playtime tracking has stopped.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StopPlaytimeTracking" class="bb_apilink">ISteamUGC::StopPlaytimeTracking</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StopPlaytimeTrackingForAllItems" class="bb_apilink">ISteamUGC::StopPlaytimeTrackingForAllItems</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct StopPlaytimeTrackingResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StopPlaytimeTrackingResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
    }
}