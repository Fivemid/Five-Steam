using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>EquippedProfileItems_t</summary>
    public unsafe struct EquippedProfileItems : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EquippedProfileItems;
        /// <summary>EResult m_eResult</summary>
        public Result eResult;
        /// <summary>CSteamID m_steamID</summary>
        public SteamId steamID;
        /// <summary>bool m_bHasAnimatedAvatar</summary>
        public bool bHasAnimatedAvatar;
        /// <summary>bool m_bHasAvatarFrame</summary>
        public bool bHasAvatarFrame;
        /// <summary>bool m_bHasProfileModifier</summary>
        public bool bHasProfileModifier;
        /// <summary>bool m_bHasProfileBackground</summary>
        public bool bHasProfileBackground;
        /// <summary>bool m_bHasMiniProfileBackground</summary>
        public bool bHasMiniProfileBackground;
    }
}