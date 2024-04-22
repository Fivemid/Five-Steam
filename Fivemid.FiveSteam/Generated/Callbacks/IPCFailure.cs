using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Called when the callback system for this client is in an error state (and has flushed pending callbacks)<br />
    /// When getting this message the client should disconnect from Steam, reset any stored Steam state and reconnect.<br />
    /// This usually occurs in the rare event the Steam client has some kind of fatal error.<br />
    /// <br />
    /// </summary>
    public unsafe struct IPCFailure : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.IPCFailure;
        /// <summary>This is a <a href="https://partner.steamgames.com/doc/api/ISteamUser#EFailureType" class="bb_apilink">EFailureType</a>.</summary>
        public byte eFailureType;
        /// <summary>Specifies what type of failure happened in <a href="https://partner.steamgames.com/doc/api/ISteamUser#IPCFailure_t" class="bb_apilink">IPCFailure_t</a>.<br />
        /// <br />
        /// </summary>
        public enum FailureType : int
        {
            /// <summary></summary>
            FailureFlushedCallbackQueue = 0,
            /// <summary></summary>
            FailurePipeFail = 1
        }
    }
}