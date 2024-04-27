using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when workshop item playtime tracking has started.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StartPlaytimeTracking" class="bb_apilink">ISteamUGC::StartPlaytimeTracking</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct StartPlaytimeTrackingResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StartPlaytimeTrackingResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
    }
}