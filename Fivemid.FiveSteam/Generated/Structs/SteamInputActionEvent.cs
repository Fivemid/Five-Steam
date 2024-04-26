using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// missing documentation for SteamInputActionEvent_t
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = Platform.PACK_SIZE)]
    public unsafe struct SteamInputActionEvent
    {
        /// missing documentation for SteamInputActionEvent_t.controllerHandle
        public InputHandle controllerHandle;
        /// missing documentation for SteamInputActionEvent_t.eEventType
        public SteamInputActionEventType eEventType;
    }
}