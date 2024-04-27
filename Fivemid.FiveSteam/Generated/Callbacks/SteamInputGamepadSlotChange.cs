using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamInputGamepadSlotChange_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInputGamepadSlotChange
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamInputGamepadSlotChange;
        /// missing documentation for SteamInputGamepadSlotChange_t.m_unAppID
        public AppId unAppID;
        /// missing documentation for SteamInputGamepadSlotChange_t.m_ulDeviceHandle
        public InputHandle ulDeviceHandle;
        /// missing documentation for SteamInputGamepadSlotChange_t.m_eDeviceType
        public SteamInputType eDeviceType;
        /// missing documentation for SteamInputGamepadSlotChange_t.m_nOldGamepadSlot
        public int nOldGamepadSlot;
        /// missing documentation for SteamInputGamepadSlotChange_t.m_nNewGamepadSlot
        public int nNewGamepadSlot;
    }
}