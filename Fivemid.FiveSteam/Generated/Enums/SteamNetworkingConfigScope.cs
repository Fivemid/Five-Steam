using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// <br />
    /// Configuration values can be applied to different types of objects.<br /></summary>
    public enum SteamNetworkingConfigScope : int
    {
        /// <summary>Get/set global option, or defaults.  Even options that apply to more specific scopes
        /// have global scope, and you may be able to just change the global defaults.  If you
        /// need different settings per connection (for example), then you will need to set those
        /// options at the more specific scope.</summary>
        SteamNetworkingConfig_Global = 1,
        /// <summary>Some options are specific to a particular interface.  Note that all connection
        /// and listen socket settings can also be set at the interface level, and they will
        /// apply to objects created through those interfaces.</summary>
        SteamNetworkingConfig_SocketsInterface = 2,
        /// <summary>Options for a listen socket.  Listen socket options can be set at the interface layer,
        /// if  you have multiple listen sockets and they all use the same options.
        /// You can also set connection options on a listen socket, and they set the defaults
        /// for all connections accepted through this listen socket.  (They will be used if you don't
        /// set a connection option.)</summary>
        SteamNetworkingConfig_ListenSocket = 3,
        /// <summary>Options for a specific connection.</summary>
        SteamNetworkingConfig_Connection = 4,
        /// missing documentation for ESteamNetworkingConfigScope.k_ESteamNetworkingConfigScope__Force32Bit
        _Force32Bit = 2147483647
    }
}