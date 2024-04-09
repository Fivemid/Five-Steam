using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>SteamInputActionEvent_t</summary>
    public unsafe struct SteamInputActionEvent
    {
        /// <summary>InputHandle_t controllerHandle</summary>
        public InputHandle controllerHandle;
        /// <summary>ESteamInputActionEventType eEventType</summary>
        public SteamInputActionEventType eEventType;
    }
}