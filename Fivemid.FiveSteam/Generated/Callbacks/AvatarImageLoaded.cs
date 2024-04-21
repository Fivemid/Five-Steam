using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Called when a large avatar is loaded if you have tried requesting it when it was unavailable.<br />
    /// <br />
    /// 
    /// <br />
    /// <b>Associated Functions:</b>
    /// <a href="https://partner.steamgames.com/doc/api/ISteamFriends#GetLargeFriendAvatar" class="bb_apilink">ISteamFriends::GetLargeFriendAvatar</a>
    /// </summary>
    public unsafe struct AvatarImageLoaded : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.AvatarImageLoaded;
        /// <summary>The Steam ID that the avatar has been loaded for.</summary>
        public SteamId steamID;
        /// <summary>The Steam image handle of the now loaded image.</summary>
        public int iImage;
        /// <summary>Width of the loaded image.</summary>
        public int iWide;
        /// <summary>Height of the loaded image.</summary>
        public int iTall;
    }
}