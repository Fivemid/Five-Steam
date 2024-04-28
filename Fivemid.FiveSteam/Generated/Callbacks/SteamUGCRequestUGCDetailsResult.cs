using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>DEPRECATED - Former result of a call to <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RequestUGCDetails" class="bb_apilink">ISteamUGC::RequestUGCDetails</a>.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUGC#RequestUGCDetails" class="bb_apilink">ISteamUGC::RequestUGCDetails</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamUGCRequestUGCDetailsResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamUGCRequestUGCDetailsResult;
        /// <summary>Deprecated.</summary>
        public SteamUGCDetails details;
        /// <summary>Deprecated.</summary>
        public bool bCachedData;
    }
}