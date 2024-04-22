using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Posted when the <a href="https://partner.steamgames.com/doc/features/overlay" class="bb_doclink">Steam Overlay</a> activates or deactivates. The game can use this to pause or resume single player games.<br />
    /// <br />
    /// </summary>
    public unsafe struct GameOverlayActivated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameOverlayActivated;
        /// <summary><b>1</b> if it's just been activated, otherwise <b>0</b>.</summary>
        public byte bActive;
        /// missing documentation for GameOverlayActivated_t.m_bUserInitiated
        public bool bUserInitiated;
        /// missing documentation for GameOverlayActivated_t.m_nAppID
        public AppId nAppID;
        /// missing documentation for GameOverlayActivated_t.m_dwOverlayPID
        public uint dwOverlayPID;
    }
}