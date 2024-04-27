using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Result of an achievement icon that has been fetched<br />
    /// <br />
    /// <br />
    /// <b>Associated Functions:</b> <a href="https://partner.steamgames.com/doc/api/ISteamUserStats#GetAchievementIcon" class="bb_apilink">ISteamUserStats::GetAchievementIcon</a></summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct UserAchievementIconFetched
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.UserAchievementIconFetched;
        /// <summary>The Game ID this achievement is for.</summary>
        public GameId nGameID;
        /// <summary>The name of the achievement that this callback is for.</summary>
        public UTF8String128 rgchAchievementName;
        /// <summary>Returns whether the icon for the achieved (<b>true</b>) or unachieved (<b>false</b>) version.</summary>
        public bool bAchieved;
        /// <summary>Handle to the image, which can be used with <a href="https://partner.steamgames.com/doc/api/ISteamUtils#GetImageRGBA" class="bb_apilink">ISteamUtils::GetImageRGBA</a> to get the image data. <b>0</b> means no image is set for the achievement.</summary>
        public int nIconHandle;
    }
}