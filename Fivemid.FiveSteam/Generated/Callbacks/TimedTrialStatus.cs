using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Sent every minute when a appID is owned via a timed trial.<br />
    /// <br />
    /// <br />
    /// <b>See Also:</b> <a href="https://partner.steamgames.com/doc/api/ISteamApps#BIsTimedTrial" class="bb_apilink">ISteamApps::BIsTimedTrial</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct TimedTrialStatus
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.TimedTrialStatus;
        /// <summary>AppID that is in a timed trial.</summary>
        public AppId unAppID;
        /// <summary>If true, the user is currently offline. Time allowed / played refers to offline time, not total time.</summary>
        public bool bIsOffline;
        /// <summary>How many seconds the app can be played in total.</summary>
        public uint unSecondsAllowed;
        /// <summary>How many seconds the app was already played.</summary>
        public uint unSecondsPlayed;
    }
}