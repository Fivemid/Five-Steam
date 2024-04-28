using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when a Steam group activity has been received.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamFriends#DownloadClanActivityCounts" class="bb_apilink">ISteamFriends::DownloadClanActivityCounts</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct DownloadClanActivityCountsResult
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.DownloadClanActivityCountsResult;
        /// <summary>Was the call successful?</summary>
        public bool bSuccess;
    }
}