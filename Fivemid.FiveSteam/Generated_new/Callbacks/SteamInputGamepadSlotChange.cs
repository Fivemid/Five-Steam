using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInputGamepadSlotChange_t</summary>
    public unsafe struct SteamInputGamepadSlotChange
    {
        /// <summary>AppId_t m_unAppID</summary>
        public AppId unAppID;
        /// <summary>InputHandle_t m_ulDeviceHandle</summary>
        public InputHandle ulDeviceHandle;
        /// <summary>ESteamInputType m_eDeviceType</summary>
        public SteamInputType eDeviceType;
        /// <summary>int m_nOldGamepadSlot</summary>
        public int nOldGamepadSlot;
        /// <summary>int m_nNewGamepadSlot</summary>
        public int nNewGamepadSlot;
    }
}