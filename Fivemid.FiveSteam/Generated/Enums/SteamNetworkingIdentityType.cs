using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>Different types of identities that a remote host can have.  Most of the time on Steam, this will be a CSteamID.  However, in some cases you can disable authentication, in which case a more generic identity will be used.<br />
    /// <br />
    /// </summary>
    public enum SteamNetworkingIdentityType : int
    {
        /// <summary>Dummy/unknown/invalid</summary>
        Invalid = 0,
        /// <summary>64-bit CSteamID</summary>
        SteamID = 16,
        /// missing documentation for ESteamNetworkingIdentityType.k_ESteamNetworkingIdentityType_XboxPairwiseID
        XboxPairwiseID = 17,
        /// missing documentation for ESteamNetworkingIdentityType.k_ESteamNetworkingIdentityType_SonyPSN
        SonyPSN = 18,
        /// missing documentation for ESteamNetworkingIdentityType.k_ESteamNetworkingIdentityType_GoogleStadia
        GoogleStadia = 19,
        /// <summary>Use their IP address (and port) as their "identity".
        /// These types of identities are always unauthenticated.
        /// They are useful for porting plain sockets code, and other
        /// situations where you don't care about authentication.  In this
        /// case, the local identity will be "localhost",
        /// and the remote address will be their network address.
        /// 
        /// We use the same type for either IPv4 or IPv6, and
        /// the address is always store as IPv6.  We use IPv4
        /// mapped addresses to handle IPv4.</summary>
        IPAddress = 1,
        /// <summary>Generic string/binary blobs.  It's up to your app to interpret this.
        /// This library can tell you if the remote host presented a certificate
        /// signed by somebody you have chosen to trust, with this identity on it.
        /// It's up to you to ultimately decide what this identity means.</summary>
        GenericString = 2,
        /// <summary></summary>
        GenericBytes = 3,
        /// missing documentation for ESteamNetworkingIdentityType.k_ESteamNetworkingIdentityType_UnknownType
        UnknownType = 4,
        /// <summary>Make sure this enum is stored in an int.</summary>
        _Force32bit = 2147483647
    }
}