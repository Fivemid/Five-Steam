using System;
using System.Runtime.InteropServices;

namespace Fivemid.FiveSteam
{
    /// <summary>
    /// Used to set the authentication and VAC status of a game server when initializing with
    /// <a href="#SteamGameServer_Init" class="bb_apilink">SteamGameServer_Init</a>.<br />
    /// <br />
    /// 
    /// </summary>
    public enum ServerMode : int
    {
        /// <summary>DEPRECATED - DO NOT USE!</summary>
        eServerModeInvalid = 0,
        /// <summary>Don't authenticate user logins and don't list on the server list.</summary>
        eServerModeNoAuthentication = 1,
        /// <summary>Authenticate users, list on the server list, don't run VAC on clients that connect.</summary>
        eServerModeAuthentication = 2,
        /// <summary>Authenticate users, list on the server list and VAC protect clients.</summary>
        eServerModeAuthenticationAndSecure = 3
    }
}