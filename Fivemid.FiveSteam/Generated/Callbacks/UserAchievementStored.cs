using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result of a request to store the achievements on the server, or an "indicate progress" call. If both <code class="bb_code bb_code_inline nohighlight">m_nCurProgress</code> and <code class="bb_code bb_code_inline nohighlight">m_nMaxProgress</code> are zero, that means the achievement has been fully unlocked.<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#StoreStats" class="bb_apilink">ISteamUserStats::StoreStats</a>, <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#IndicateAchievementProgress" class="bb_apilink">ISteamUserStats::IndicateAchievementProgress</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UserAchievementStored
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserAchievementStored;
        /// <summary>Game ID that this achievement is for.</summary>
        public ulong nGameID;
        /// <summary>Unused.</summary>
        public bool bGroupAchievement;
        /// <summary>Name of the achievement.</summary>
        public UTF8String128 rgchAchievementName;
        /// <summary>Current progress towards the achievement.</summary>
        public uint nCurProgress;
        /// <summary>The total amount of progress required to unlock.</summary>
        public uint nMaxProgress;
    }
}