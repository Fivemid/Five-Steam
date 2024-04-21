using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when workshop item playtime tracking has started.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamUGC#StartPlaytimeTracking" class="bb_apilink">ISteamUGC::StartPlaytimeTracking</a>
    /// </summary>
    public unsafe struct StartPlaytimeTrackingResult : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.StartPlaytimeTrackingResult;
        /// <summary>The result of the operation.</summary>
        public Result eResult;
    }
}