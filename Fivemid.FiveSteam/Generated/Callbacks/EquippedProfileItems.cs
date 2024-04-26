using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><a href="https://partner.steamgames.com/doc/sdk/api#callresults" class="bb_doclink">CallResult</a> from <a href="https://partner.steamgames.com/doc/api/ISteamFriends#RequestEquippedProfileItems" class="bb_apilink">ISteamFriends::RequestEquippedProfileItems</a>.  Also sent as a <a href="https://partner.steamgames.com/doc/sdk/api#callbacks" class="bb_doclink">Callback</a>.<br />
    /// <br />
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct EquippedProfileItems : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.EquippedProfileItems;
        /// <summary></summary>
        public Result eResult;
        /// missing documentation for EquippedProfileItems_t.m_steamID
        public SteamId steamID;
        /// <summary></summary>
        public bool bHasAnimatedAvatar;
        /// <summary></summary>
        public bool bHasAvatarFrame;
        /// <summary></summary>
        public bool bHasProfileModifier;
        /// <summary></summary>
        public bool bHasProfileBackground;
        /// <summary></summary>
        public bool bHasMiniProfileBackground;
    }
}