using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Deprecated - Use <a href="https://partner.steamgames.com/doc/api/ISteamGameServerStats" class="bb_apilink">ISteamGameServerStats</a> instead.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct GSClientAchievementStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GSClientAchievementStatus;
        /// <summary>Deprecated</summary>
        public ulong SteamID;
        /// <summary>Deprecated</summary>
        public UTF8String128 pchAchievement;
        /// <summary>Deprecated</summary>
        public bool bUnlocked;
    }
}