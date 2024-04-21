using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// A struct used to describe our readiness to participate in authenticated, encrypted communication. In
    /// order to do this we need:<br />
    /// <ul class="bb_ul">
    ///     <li>The list of trusted CA certificates that might be relevant for this app.<br /></li>
    ///     <li>A valid certificate issued by a CA.</li>
    /// </ul>
    /// <br />
    /// This callback is posted whenever the state of our readiness changes.<br />
    /// <br />
    /// <code>
    ///     struct SteamNetAuthenticationStatus_t { /// Status ESteamNetworkingAvailability m_eAvail; ///
    ///     Non-localized English language status. For diagnostic/debugging /// purposes only. char
    ///     m_debugMsg[]; };
    /// </code>
    /// </summary>
    public unsafe struct SteamNetAuthenticationStatus : global::Unity.Entities.IComponentData
    {
        public static readonly CallbackIdentifier IDENTIFIER = CallbackIdentifier.SteamNetAuthenticationStatus;
        /// missing documentation for SteamNetAuthenticationStatus_t.m_eAvail
        public SteamNetworkingAvailability eAvail;
        /// missing documentation for SteamNetAuthenticationStatus_t.m_debugMsg
        public UTF8String256 debugMsg;
    }
}