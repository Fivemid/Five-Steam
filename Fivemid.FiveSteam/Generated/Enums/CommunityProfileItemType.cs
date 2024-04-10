using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>ECommunityProfileItemType</summary>
    public enum CommunityProfileItemType : int
    {
        /// <summary>k_ECommunityProfileItemType_AnimatedAvatar</summary>
        AnimatedAvatar = 0,
        /// <summary>k_ECommunityProfileItemType_AvatarFrame</summary>
        AvatarFrame = 1,
        /// <summary>k_ECommunityProfileItemType_ProfileModifier</summary>
        ProfileModifier = 2,
        /// <summary>k_ECommunityProfileItemType_ProfileBackground</summary>
        ProfileBackground = 3,
        /// <summary>k_ECommunityProfileItemType_MiniProfileBackground</summary>
        MiniProfileBackground = 4
    }
}