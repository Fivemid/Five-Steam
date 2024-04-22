using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary><br />
    /// Enumerate various causes of connection termination.  These are designed to work similar to HTTP error codes: the numeric range gives you a rough classification as to the source of the problem.<br />
    /// </summary>
    public enum SteamNetConnectionEnd : int
    {
        /// <summary>Invalid/sentinel value</summary>
        Invalid = 0,
        /// <summary>1xxx: Application ended the connection in a "usual" manner.
        /// E.g.: user intentionally disconnected from the server,
        /// gameplay ended normally, etc</summary>
        App_Min = 1000,
        /// <summary></summary>
        App_Generic = 1000,
        /// <summary>Use codes in this range for "normal" disconnection</summary>
        App_Max = 1999,
        /// <summary>2xxx: Application ended the connection in some sort of exceptional
        /// or unusual manner that might indicate a bug or configuration
        /// issue.
        /// </summary>
        AppException_Min = 2000,
        /// <summary></summary>
        AppException_Generic = 2000,
        /// <summary>Use codes in this range for "unusual" disconnection</summary>
        AppException_Max = 2999,
        /// <summary>3xxx: Connection failed or ended because of problem with the
        /// local host or their connection to the Internet.</summary>
        Local_Min = 3000,
        /// <summary>You cannot do what you want to do because you're running in offline mode.</summary>
        Local_OfflineMode = 3001,
        /// <summary>We're having trouble contacting many (perhaps all) relays.
        /// Since it's unlikely that they all went offline at once, the best
        /// explanation is that we have a problem on our end.  Note that we don't
        /// bother distinguishing between "many" and "all", because in practice,
        /// it takes time to detect a connection problem, and by the time
        /// the connection has timed out, we might not have been able to
        /// actively probe all of the relay clusters, even if we were able to
        /// contact them at one time.  So this code just means that:
        /// 
        /// * We don't have any recent successful communication with any relay.
        /// * We have evidence of recent failures to communicate with multiple relays.</summary>
        Local_ManyRelayConnectivity = 3002,
        /// <summary>A hosted server is having trouble talking to the relay
        /// that the client was using, so the problem is most likely
        /// on our end</summary>
        Local_HostedServerPrimaryRelay = 3003,
        /// <summary>We're not able to get the network config.  This is
        /// *almost* always a local issue, since the network config
        /// comes from the CDN, which is pretty darn reliable.</summary>
        Local_NetworkConfig = 3004,
        /// <summary>Steam rejected our request because we don't have rights
        /// to do this.</summary>
        Local_Rights = 3005,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses
        Local_P2P_ICE_NoPublicAddresses = 3006,
        /// <summary></summary>
        Local_Max = 3999,
        /// <summary>4xxx: Connection failed or ended, and it appears that the
        /// cause does NOT have to do with the local host or their
        /// connection to the Internet.  It could be caused by the
        /// remote host, or it could be somewhere in between.</summary>
        Remote_Min = 4000,
        /// <summary>The connection was lost, and as far as we can tell our connection
        /// to relevant services (relays) has not been disrupted.  This doesn't
        /// mean that the problem is "their fault", it just means that it doesn't
        /// appear that we are having network issues on our end.</summary>
        Remote_Timeout = 4001,
        /// <summary>Something was invalid with the cert or crypt handshake
        /// info you gave me, I don't understand or like your key types,
        /// etc.</summary>
        Remote_BadCrypt = 4002,
        /// <summary>You presented me with a cert that was I was able to parse
        /// and *technically* we could use encrypted communication.
        /// But there was a problem that prevents me from checking your identity
        /// or ensuring that somebody int he middle can't observe our communication.
        /// E.g.: - the CA key was missing (and I don't accept unsigned certs)
        /// - The CA key isn't one that I trust,
        /// - The cert doesn't was appropriately restricted by app, user, time, data center, etc.
        /// - The cert wasn't issued to you.
        /// - etc</summary>
        Remote_BadCert = 4003,
        /// <summary>Something wrong with the protocol version you are using.
        /// (Probably the code you are running is too old.)</summary>
        Remote_BadProtocolVersion = 4006,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses
        Remote_P2P_ICE_NoPublicAddresses = 4007,
        /// <summary></summary>
        Remote_Max = 4999,
        /// <summary>5xxx: Connection failed for some other reason.</summary>
        Misc_Min = 5000,
        /// <summary>A failure that isn't necessarily the result of a software bug,
        /// but that should happen rarely enough that it isn't worth specifically
        /// writing UI or making a localized message for.
        /// The debug string should contain further details.</summary>
        Misc_Generic = 5001,
        /// <summary>Generic failure that is most likely a software bug.</summary>
        Misc_InternalError = 5002,
        /// <summary>The connection to the remote host timed out, but we
        /// don't know if the problem is on our end, in the middle,
        /// or on their end.</summary>
        Misc_Timeout = 5003,
        /// <summary>There's some trouble talking to Steam.</summary>
        Misc_SteamConnectivity = 5005,
        /// <summary>A server in a dedicated hosting situation has no relay sessions
        /// active with which to talk back to a client.  (It's the client's
        /// job to open and maintain those sessions.)</summary>
        Misc_NoRelaySessionsToClient = 5006,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous
        Misc_P2P_Rendezvous = 5008,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall
        Misc_P2P_NAT_Firewall = 5009,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection
        Misc_PeerSentNoConnection = 5010,
        /// <summary></summary>
        Misc_Max = 5999,
        /// missing documentation for ESteamNetConnectionEnd.k_ESteamNetConnectionEnd__Force32Bit
        _Force32Bit = 2147483647
    }
}