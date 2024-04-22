using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// A struct used to describe our readiness to participate in authenticated, encrypted communication.  In order to do this we need:<br />
    /// <ul class="bb_ul "><li> The list of trusted CA certificates that might be relevant for this app.<br />
    /// </li><li> A valid certificate issued by a CA.</li></ul><br />
    /// This callback is posted whenever the state of our readiness changes.<br />
    /// <br />
    /// </summary>
    public unsafe struct SteamNetAuthenticationStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetAuthenticationStatus;
        /// <summary>Status</summary>
        public SteamNetworkingAvailability eAvail;
        /// <summary>Non-localized English language status.  For diagnostic/debugging
        /// purposes only.</summary>
        public UTF8String256 debugMsg;
    }
}