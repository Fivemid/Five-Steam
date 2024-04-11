using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>GameOverlayActivated_t</summary>
    public unsafe struct GameOverlayActivated : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.GameOverlayActivated;
        /// <summary>uint8 m_bActive</summary>
        public byte bActive;
        /// <summary>bool m_bUserInitiated</summary>
        public bool bUserInitiated;
        /// <summary>AppId_t m_nAppID</summary>
        public AppId nAppID;
        /// <summary>uint32 m_dwOverlayPID</summary>
        public uint dwOverlayPID;
    }
}